using System;
using System.Collections;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Stuff
{
	internal class MemoryClass
	{
		private IntPtr pHandel;

		private Process attachedProcess = null;

		private string lastError = null;

		private char[] validCharList = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890~!@#$%^&*()_+-=` ".ToArray<char>();

		public MemoryClass()
		{
		}

		public string GetLastError()
		{
			return this.lastError;
		}

		private bool IsValidChar(char toCheckVar)
		{
			bool flag;
			toCheckVar = toCheckVar.ToString().ToLower().ToCharArray()[0];
			int num = 0;
			while (true)
			{
				if (num >= (int)this.validCharList.Length)
				{
					flag = false;
					break;
				}
				else if (toCheckVar != this.validCharList[num])
				{
					num++;
				}
				else
				{
					flag = true;
					break;
				}
			}
			return flag;
		}

		public int PatternScan32(string pattern, bool mainModule = true)
		{
			int i;
			string[] strArrays = pattern.Split(new char[] { ' ' });
			bool[] flagArray = new bool[(int)strArrays.Length];
			byte[] numArray = new byte[(int)strArrays.Length];
			byte num = 0;
			for (i = 0; i < (int)strArrays.Length; i++)
			{
				flagArray[i] = (strArrays[i] == "??" ? false : !(strArrays[i] == "?"));
				if (!byte.TryParse(strArrays[i], out num))
				{
					flagArray[i] = false;
				}
				else
				{
					numArray[i] = num;
				}
			}
			int num1 = 0;
			int moduleMemorySize = 0;
			if (!mainModule)
			{
				for (i = 0; i < this.attachedProcess.Modules.Count; i++)
				{
					moduleMemorySize += this.attachedProcess.Modules[i].ModuleMemorySize;
				}
			}
			else
			{
				num1 = this.attachedProcess.MainModule.BaseAddress.ToInt32();
				moduleMemorySize = this.attachedProcess.MainModule.ModuleMemorySize;
			}
			for (int j = num1; j < moduleMemorySize; j++)
			{
				bool flag = false;
				for (i = 0; i < (int)strArrays.Length; i++)
				{
					if (flagArray[i])
					{
						num = this.ReadBytes32(j + i, 1)[0];
						if (num == numArray[i])
						{
							if (i == (int)strArrays.Length - 1)
							{
								flag = true;
							}
							if (flag)
							{
								break;
							}
						}
						else
						{
							break;
						}
					}
				}
				if (flag)
				{
					return j;
				}
			}
			throw new Exception("Pattern not found!");
		}

		public bool Process_Handle(string ProcessName)
		{
			bool flag;
			try
			{
				Process[] processesByName = Process.GetProcessesByName(ProcessName);
				if ((int)processesByName.Length != 0)
				{
					this.attachedProcess = processesByName[0];
					this.pHandel = processesByName[0].Handle;
					flag = true;
				}
				else
				{
					flag = false;
				}
			}
			catch (Exception exception)
			{
				this.SetLastError(exception);
				flag = false;
			}
			return flag;
		}

		public byte[] Read32(int Address, int Length)
		{
			byte[] numArray = new byte[Length];
			IntPtr zero = IntPtr.Zero;
			MemoryClass.ReadProcessMemory(this.pHandel, (IntPtr)Address, numArray, (uint)numArray.Length, out zero);
			return numArray;
		}

		private byte[] Read64(long Address, int Length)
		{
			byte[] numArray = new byte[Length];
			IntPtr zero = IntPtr.Zero;
			MemoryClass.ReadProcessMemory(this.pHandel, (IntPtr)Address, numArray, (uint)numArray.Length, out zero);
			return numArray;
		}

		public byte[] ReadBytes32(int Address, int Length)
		{
			return this.Read32(Address, Length);
		}

		public byte[] ReadBytes64(long Address, int Length)
		{
			return this.Read64(Address, Length);
		}

		public double ReadDouble32(int address)
		{
			byte[] numArray = new byte[8];
			IntPtr zero = IntPtr.Zero;
			MemoryClass.ReadProcessMemory(this.pHandel, (IntPtr)address, numArray, (uint)numArray.Length, out zero);
			return BitConverter.ToDouble(numArray, 0);
		}

		public float ReadFloat32(int address)
		{
			float single = BitConverter.ToSingle(this.ReadBytes32(address, 8), 0);
			return single;
		}

		public int ReadInteger32(int Address, int Length = 4)
		{
			int num = BitConverter.ToInt32(this.Read32(Address, Length), 0);
			return num;
		}

		public int ReadInteger64(long Address, int Length = 4)
		{
			int num = BitConverter.ToInt32(this.Read64(Address, Length), 0);
			return num;
		}

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

		public string ReadString_Advanced32(int offset)
		{
			string str = null;
			int num = 0;
			while (true)
			{
				byte[] numArray = this.ReadBytes32(offset + num, 1);
				char chars = Encoding.ASCII.GetChars(numArray)[0];
				if (!this.IsValidChar(chars))
				{
					break;
				}
				else
				{
					str = string.Concat(str, chars.ToString());
					num++;
					if (num > 10000)
					{
						break;
					}
				}
			}
			return str;
		}

		public string ReadString_Advanced64(long offset)
		{
			string str = null;
			int num = 0;
			while (true)
			{
				byte[] numArray = this.ReadBytes64(offset + (long)num, 1);
				char chars = Encoding.ASCII.GetChars(numArray)[0];
				if (!this.IsValidChar(chars))
				{
					break;
				}
				else
				{
					str = string.Concat(str, chars.ToString());
					num++;
					if (num > 10000)
					{
						break;
					}
				}
			}
			return str;
		}

		public string ReadString32(int Address, int Length = 4)
		{
			string str = (new ASCIIEncoding()).GetString(this.Read32(Address, Length));
			return str;
		}

		public string ReadString64(long Address, int Length = 4)
		{
			string str = (new ASCIIEncoding()).GetString(this.Read64(Address, Length));
			return str;
		}

		private void SetLastError(string error)
		{
			this.lastError = error;
		}

		private void SetLastError(Exception error)
		{
			this.lastError = error.ToString();
		}

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false, SetLastError=true)]
		public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect);

		public void Write32(int Address, int Value)
		{
			byte[] bytes = BitConverter.GetBytes(Value);
			IntPtr zero = IntPtr.Zero;
			MemoryClass.WriteProcessMemory(this.pHandel, (IntPtr)Address, bytes, (uint)bytes.Length, out zero);
		}

		private void Write64(long Address, int Value)
		{
			byte[] bytes = BitConverter.GetBytes(Value);
			IntPtr zero = IntPtr.Zero;
			MemoryClass.WriteProcessMemory(this.pHandel, (IntPtr)Address, bytes, (uint)bytes.Length, out zero);
		}

		public void WriteBytes32(int Address, byte[] Bytes)
		{
			IntPtr zero = IntPtr.Zero;
			MemoryClass.WriteProcessMemory(this.pHandel, (IntPtr)Address, Bytes, (uint)Bytes.Length, out zero);
		}

		public void WriteBytes64(long Address, byte[] Bytes)
		{
			IntPtr zero = IntPtr.Zero;
			MemoryClass.WriteProcessMemory(this.pHandel, (IntPtr)Address, Bytes, (uint)Bytes.Length, out zero);
		}

		public void WriteDouble32(int Address, double value)
		{
			byte[] bytes = BitConverter.GetBytes(value);
			IntPtr zero = IntPtr.Zero;
			MemoryClass.WriteProcessMemory(this.pHandel, (IntPtr)Address, bytes, (uint)bytes.Length, out zero);
		}

		public void WriteFloat_Protected32(int Address, float Value)
		{
			uint num;
			MemoryClass.VirtualProtectEx(this.pHandel, (IntPtr)Address, 4, 64, out num);
			this.WriteFloat32(Address, Value);
			MemoryClass.VirtualProtectEx(this.pHandel, (IntPtr)Address, 4, num, out num);
		}

		private void WriteFloat32(int Address, float Value)
		{
			byte[] bytes = BitConverter.GetBytes(Value);
			IntPtr zero = IntPtr.Zero;
			MemoryClass.WriteProcessMemory(this.pHandel, (IntPtr)Address, bytes, (uint)bytes.Length, out zero);
		}

		public void WriteFloat64(long Address, float Float)
		{
			byte[] bytes = BitConverter.GetBytes(Float);
			IntPtr zero = IntPtr.Zero;
			MemoryClass.WriteProcessMemory(this.pHandel, (IntPtr)Address, bytes, (uint)bytes.Length, out zero);
		}

		public void WriteInteger(int Address, int Value)
		{
			this.Write32(Address, Value);
		}

		public void WriteInteger64(long Address, int Value)
		{
			this.Write64(Address, Value);
		}

		public void WriteNOP32(int Address, int nopLength)
		{
			byte[] numArray = new byte[nopLength];
			for (int i = 0; i < nopLength; i++)
			{
				numArray[i] = 144;
			}
			IntPtr zero = IntPtr.Zero;
			MemoryClass.WriteProcessMemory(this.pHandel, (IntPtr)Address, numArray, (uint)numArray.Length, out zero);
		}

		public void WriteNOP64(long Address)
		{
			byte[] numArray = new byte[] { 144, 144, 144, 144, 144 };
			IntPtr zero = IntPtr.Zero;
			MemoryClass.WriteProcessMemory(this.pHandel, (IntPtr)Address, numArray, (uint)numArray.Length, out zero);
		}

		[DllImport("kernel32.dll", CharSet=CharSet.None, ExactSpelling=false)]
		private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [In][Out] byte[] buffer, uint size, out IntPtr lpNumberOfBytesWritten);

		public void WriteString32(int Address, string Text)
		{
			byte[] bytes = (new ASCIIEncoding()).GetBytes(Text);
			IntPtr zero = IntPtr.Zero;
			MemoryClass.WriteProcessMemory(this.pHandel, (IntPtr)Address, bytes, (uint)bytes.Length, out zero);
		}

		public void WriteString64(long Address, string Text)
		{
			byte[] bytes = (new ASCIIEncoding()).GetBytes(Text);
			IntPtr zero = IntPtr.Zero;
			MemoryClass.WriteProcessMemory(this.pHandel, (IntPtr)Address, bytes, (uint)bytes.Length, out zero);
		}
	}
}