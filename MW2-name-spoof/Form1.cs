using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Stuff
{
	public class Form1 : Form
	{
		private MemoryClass Memeditor = new MemoryClass();

		private IContainer components = null;

		private TextBox textBox1;

		private Button button1;

		private RadioButton radioButton1;

		private RadioButton radioButton2;

		private Timer RTE;

		private Timer Flash;

		private RadioButton radioButton3;

		private CheckBox checkBox1;

		private CheckBox checkBox2;

		private Timer RankL;

		private Timer PrestigeL;

		private Label label1;

		public Form1()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Memeditor.WriteString32(10182656, string.Concat(this.textBox1.Text, "\0"));
			if (this.textBox1.TextLength == 0)
			{
				this.Memeditor.WriteString32(10182656, " \0");
			}
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkBox1.Checked)
			{
				this.RankL.Stop();
			}
			else
			{
				this.RankL.Start();
			}
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.checkBox2.Checked)
			{
				this.PrestigeL.Stop();
			}
			else
			{
				this.PrestigeL.Start();
			}
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Flash_Tick(object sender, EventArgs e)
		{
			int num = (new Random()).Next(0, 6);
			MemoryClass memeditor = this.Memeditor;
			object[] text = new object[] { "^", num, this.textBox1.Text, "\0" };
			memeditor.WriteString32(10182656, string.Concat(text));
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.Memeditor.Process_Handle("iw4mp");
			byte[] numArray = new byte[] { 117 };
			this.Memeditor.WriteBytes32(6452491, numArray);
			numArray = new byte[] { 0, 96, 155, 0 };
			this.Memeditor.WriteBytes32(6452505, numArray);
			if (this.textBox1.TextLength == 0)
			{
				this.Memeditor.WriteString32(10182656, " \0");
			}
		}

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.textBox1 = new TextBox();
			this.button1 = new Button();
			this.radioButton1 = new RadioButton();
			this.radioButton2 = new RadioButton();
			this.RTE = new Timer(this.components);
			this.Flash = new Timer(this.components);
			this.radioButton3 = new RadioButton();
			this.checkBox1 = new CheckBox();
			this.checkBox2 = new CheckBox();
			this.RankL = new Timer(this.components);
			this.PrestigeL = new Timer(this.components);
			this.label1 = new Label();
			base.SuspendLayout();
			this.textBox1.Location = new Point(12, 12);
			this.textBox1.MaxLength = 32;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(339, 20);
			this.textBox1.TabIndex = 0;
			this.button1.Location = new Point(12, 38);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(339, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Spoof Name";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new Point(12, 90);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(94, 17);
			this.radioButton1.TabIndex = 2;
			this.radioButton1.Text = "RTE";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new EventHandler(this.radioButton1_CheckedChanged);
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new Point(12, 113);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(50, 17);
			this.radioButton2.TabIndex = 3;
			this.radioButton2.Text = "Name Flash";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new EventHandler(this.radioButton2_CheckedChanged);
			this.RTE.Tick += new EventHandler(this.RTE_Tick);
			this.Flash.Tick += new EventHandler(this.Flash_Tick);
			this.radioButton3.AutoSize = true;
			this.radioButton3.Checked = true;
			this.radioButton3.Location = new Point(12, 67);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(51, 17);
			this.radioButton3.TabIndex = 4;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "None";
			this.radioButton3.UseVisualStyleBackColor = true;
			this.radioButton3.CheckedChanged += new EventHandler(this.radioButton3_CheckedChanged);
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new Point(260, 68);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(79, 17);
			this.checkBox1.TabIndex = 5;
			this.checkBox1.Text = "Loop Rank";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new Point(260, 91);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(91, 17);
			this.checkBox2.TabIndex = 6;
			this.checkBox2.Text = "Loop Prestige";
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
			this.RankL.Tick += new EventHandler(this.RankL_Tick);
			this.PrestigeL.Tick += new EventHandler(this.PrestigeL_Tick);
			this.label1.AutoSize = true;
			this.label1.Location = new Point(257, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "OTHER SHIT";
			this.label1.Click += new EventHandler(this.label1_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(363, 135);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.checkBox2);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.radioButton3);
			base.Controls.Add(this.radioButton2);
			base.Controls.Add(this.radioButton1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.textBox1);
			this.MaximumSize = new System.Drawing.Size(379, 174);
			this.MinimumSize = new System.Drawing.Size(379, 174);
			base.Name = "Form1";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "GITHUB.COM/WiiZARDD - MW2 NAME SPOOFER";
			base.Load += new EventHandler(this.Form1_Load);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private void label1_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Welcome to WiiZARDD'S RCE Menu. \n I would like to say, Missouri's old RCE contained \n CiD Rippers and Skid Trappers, so I have \n Released a SOLID build. - WiZ", "MW2 RCE [PUBLIC]", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
			{
				(new Form3()).Show();
			}
			else
			{
				(new Form2()).Show();
			}
		}

		private void PrestigeL_Tick(object sender, EventArgs e)
		{
			Random random = new Random();
			byte[] bytes = BitConverter.GetBytes(random.Next(0, 11));
			Array.Resize<byte>(ref bytes, (int)bytes.Length + 1);
			this.Memeditor.WriteBytes32(28882928, bytes);
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.radioButton1.Checked)
			{
				this.RTE.Stop();
			}
			else
			{
				this.RTE.Start();
			}
		}

		private void radioButton2_CheckedChanged(object sender, EventArgs e)
		{
			if (!this.radioButton2.Checked)
			{
				this.Flash.Stop();
			}
			else
			{
				this.Flash.Start();
			}
		}

		private void radioButton3_CheckedChanged(object sender, EventArgs e)
		{
			this.RTE.Stop();
			this.Flash.Stop();
		}

		private void RankL_Tick(object sender, EventArgs e)
		{
			Random random = new Random();
			byte[] bytes = BitConverter.GetBytes(random.Next(0, 2516000));
			Array.Resize<byte>(ref bytes, (int)bytes.Length + 1);
			this.Memeditor.WriteBytes32(28882920, bytes);
		}

		private void RTE_Tick(object sender, EventArgs e)
		{
			this.Memeditor.WriteString32(10182656, string.Concat(this.textBox1.Text, "\0"));
			if (this.textBox1.TextLength == 0)
			{
				this.Memeditor.WriteString32(10182656, " \0");
			}
		}
	}
}