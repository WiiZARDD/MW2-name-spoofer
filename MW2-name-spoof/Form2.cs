using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Stuff
{
	public class Form2 : Form
	{
		private MemoryClass MemEditor = new MemoryClass();

		private IContainer components = null;

		private Label label1;

		private Label label2;

		private NumericUpDown numericUpDown1;

		private NumericUpDown numericUpDown2;

		private NumericUpDown numericUpDown3;

		private NumericUpDown numericUpDown4;

		private Label label3;

		private Label label4;

		private NumericUpDown numericUpDown5;

		private NumericUpDown numericUpDown6;

		private Label label5;

		private Label label6;

		private CheckBox checkBox1;

		private CheckBox checkBox2;

		private CheckBox checkBox3;

		private CheckBox checkBox4;

		private CheckBox checkBox5;

		private CheckBox checkBox6;

		private Label label7;

		private Label label8;

		private Label label9;

		private Label label10;

		private Label label11;

		private Label label12;

		private CheckBox checkBox7;

		private CheckBox checkBox8;

		private CheckBox checkBox9;

		private CheckBox checkBox10;

		private CheckBox checkBox11;

		private CheckBox checkBox12;

		private NumericUpDown numericUpDown7;

		private NumericUpDown numericUpDown8;

		private NumericUpDown numericUpDown9;

		private NumericUpDown numericUpDown10;

		private NumericUpDown numericUpDown11;

		private NumericUpDown numericUpDown12;

		private CheckBox checkBox13;

		private NumericUpDown numericUpDown13;

		private Label label13;

		private Button button1;

		public Form2()
		{
			this.InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			byte[] numArray = new byte[] { 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144, 144 };
			this.MemEditor.WriteBytes32(28884496, numArray);
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown1.Value));
			this.MemEditor.WriteBytes32(28882920, bytes);
		}

		private void checkBox10_CheckedChanged(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown10.Value));
			this.MemEditor.WriteBytes32(28882960, bytes);
		}

		private void checkBox11_CheckedChanged(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown11.Value));
			this.MemEditor.WriteBytes32(28882940, bytes);
		}

		private void checkBox12_CheckedChanged(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown12.Value));
			this.MemEditor.WriteBytes32(28883004, bytes);
		}

		private void checkBox13_CheckedChanged(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown13.Value));
			this.MemEditor.WriteBytes32(28880876, bytes);
			this.MemEditor.WriteBytes32(28880880, bytes);
			this.MemEditor.WriteBytes32(28880884, bytes);
			this.MemEditor.WriteBytes32(28880888, bytes);
			this.MemEditor.WriteBytes32(28880892, bytes);
			this.MemEditor.WriteBytes32(28880896, bytes);
			this.MemEditor.WriteBytes32(28880900, bytes);
			this.MemEditor.WriteBytes32(28880904, bytes);
			this.MemEditor.WriteBytes32(28880908, bytes);
			this.MemEditor.WriteBytes32(28880912, bytes);
			this.MemEditor.WriteBytes32(28880916, bytes);
			this.MemEditor.WriteBytes32(28880920, bytes);
			this.MemEditor.WriteBytes32(28880924, bytes);
			this.MemEditor.WriteBytes32(28880928, bytes);
			this.MemEditor.WriteBytes32(28880932, bytes);
			this.MemEditor.WriteBytes32(28880936, bytes);
			this.MemEditor.WriteBytes32(28880940, bytes);
			this.MemEditor.WriteBytes32(28880944, bytes);
			this.MemEditor.WriteBytes32(28880948, bytes);
			this.MemEditor.WriteBytes32(28880952, bytes);
			this.MemEditor.WriteBytes32(28880956, bytes);
			this.MemEditor.WriteBytes32(28880960, bytes);
			this.MemEditor.WriteBytes32(28880964, bytes);
			this.MemEditor.WriteBytes32(28880968, bytes);
			this.MemEditor.WriteBytes32(28880972, bytes);
			this.MemEditor.WriteBytes32(28880976, bytes);
			this.MemEditor.WriteBytes32(28880980, bytes);
			this.MemEditor.WriteBytes32(28880984, bytes);
			this.MemEditor.WriteBytes32(28880988, bytes);
			this.MemEditor.WriteBytes32(28880992, bytes);
			this.MemEditor.WriteBytes32(28880996, bytes);
			this.MemEditor.WriteBytes32(28881000, bytes);
			this.MemEditor.WriteBytes32(28881004, bytes);
			this.MemEditor.WriteBytes32(28881008, bytes);
			this.MemEditor.WriteBytes32(28881012, bytes);
			this.MemEditor.WriteBytes32(28881016, bytes);
			this.MemEditor.WriteBytes32(28881020, bytes);
			this.MemEditor.WriteBytes32(28881024, bytes);
			this.MemEditor.WriteBytes32(28881028, bytes);
			this.MemEditor.WriteBytes32(28881032, bytes);
			this.MemEditor.WriteBytes32(28881036, bytes);
			this.MemEditor.WriteBytes32(28881040, bytes);
			this.MemEditor.WriteBytes32(28881044, bytes);
			this.MemEditor.WriteBytes32(28881048, bytes);
			this.MemEditor.WriteBytes32(28881052, bytes);
			this.MemEditor.WriteBytes32(28881056, bytes);
			this.MemEditor.WriteBytes32(28881060, bytes);
			this.MemEditor.WriteBytes32(28881064, bytes);
			this.MemEditor.WriteBytes32(28881068, bytes);
			this.MemEditor.WriteBytes32(28881072, bytes);
			this.MemEditor.WriteBytes32(28881076, bytes);
			this.MemEditor.WriteBytes32(28881080, bytes);
			this.MemEditor.WriteBytes32(28881084, bytes);
			this.MemEditor.WriteBytes32(28881088, bytes);
			this.MemEditor.WriteBytes32(28881092, bytes);
			this.MemEditor.WriteBytes32(28881096, bytes);
			this.MemEditor.WriteBytes32(28881100, bytes);
			this.MemEditor.WriteBytes32(28881104, bytes);
			this.MemEditor.WriteBytes32(28881108, bytes);
			this.MemEditor.WriteBytes32(28881112, bytes);
			this.MemEditor.WriteBytes32(28881116, bytes);
			this.MemEditor.WriteBytes32(28881120, bytes);
			this.MemEditor.WriteBytes32(28881124, bytes);
			this.MemEditor.WriteBytes32(28881128, bytes);
			this.MemEditor.WriteBytes32(28881132, bytes);
			this.MemEditor.WriteBytes32(28881136, bytes);
			this.MemEditor.WriteBytes32(28881140, bytes);
			this.MemEditor.WriteBytes32(28881144, bytes);
			this.MemEditor.WriteBytes32(28881148, bytes);
			this.MemEditor.WriteBytes32(28881152, bytes);
			this.MemEditor.WriteBytes32(28881156, bytes);
			this.MemEditor.WriteBytes32(28881160, bytes);
			this.MemEditor.WriteBytes32(28881164, bytes);
			this.MemEditor.WriteBytes32(28881168, bytes);
			this.MemEditor.WriteBytes32(28881172, bytes);
			this.MemEditor.WriteBytes32(28881176, bytes);
			this.MemEditor.WriteBytes32(28881180, bytes);
			this.MemEditor.WriteBytes32(28881184, bytes);
			this.MemEditor.WriteBytes32(28881188, bytes);
			this.MemEditor.WriteBytes32(28881192, bytes);
			this.MemEditor.WriteBytes32(28881196, bytes);
			this.MemEditor.WriteBytes32(28881200, bytes);
			this.MemEditor.WriteBytes32(28881204, bytes);
			this.MemEditor.WriteBytes32(28881208, bytes);
			this.MemEditor.WriteBytes32(28881212, bytes);
			this.MemEditor.WriteBytes32(28881216, bytes);
			this.MemEditor.WriteBytes32(28881220, bytes);
			this.MemEditor.WriteBytes32(28881224, bytes);
			this.MemEditor.WriteBytes32(28881228, bytes);
			this.MemEditor.WriteBytes32(28881232, bytes);
			this.MemEditor.WriteBytes32(28881236, bytes);
			this.MemEditor.WriteBytes32(28881240, bytes);
			this.MemEditor.WriteBytes32(28881244, bytes);
			this.MemEditor.WriteBytes32(28881248, bytes);
			this.MemEditor.WriteBytes32(28881252, bytes);
			this.MemEditor.WriteBytes32(28881256, bytes);
			this.MemEditor.WriteBytes32(28881260, bytes);
			this.MemEditor.WriteBytes32(28881264, bytes);
			this.MemEditor.WriteBytes32(28881268, bytes);
			this.MemEditor.WriteBytes32(28881272, bytes);
			this.MemEditor.WriteBytes32(28881276, bytes);
			this.MemEditor.WriteBytes32(28881280, bytes);
			this.MemEditor.WriteBytes32(28881284, bytes);
			this.MemEditor.WriteBytes32(28881288, bytes);
			this.MemEditor.WriteBytes32(28881292, bytes);
			this.MemEditor.WriteBytes32(28881296, bytes);
			this.MemEditor.WriteBytes32(28881300, bytes);
			this.MemEditor.WriteBytes32(28881304, bytes);
			this.MemEditor.WriteBytes32(28881308, bytes);
			this.MemEditor.WriteBytes32(28881312, bytes);
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown2.Value));
			this.MemEditor.WriteBytes32(28882928, bytes);
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown3.Value));
			this.MemEditor.WriteBytes32(28882992, bytes);
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown4.Value));
			this.MemEditor.WriteBytes32(28882936, bytes);
		}

		private void checkBox5_CheckedChanged(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown5.Value));
			this.MemEditor.WriteBytes32(28883000, bytes);
		}

		private void checkBox6_CheckedChanged(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown6.Value));
			this.MemEditor.WriteBytes32(28882996, bytes);
		}

		private void checkBox7_CheckedChanged(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown7.Value));
			this.MemEditor.WriteBytes32(28882948, bytes);
		}

		private void checkBox8_CheckedChanged(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown8.Value));
			this.MemEditor.WriteBytes32(28882944, bytes);
		}

		private void checkBox9_CheckedChanged(object sender, EventArgs e)
		{
			byte[] bytes = BitConverter.GetBytes(Convert.ToInt32(this.numericUpDown9.Value));
			this.MemEditor.WriteBytes32(28882956, bytes);
		}

		protected override void Dispose(bool disposing)
		{
			if ((!disposing ? false : this.components != null))
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			this.MemEditor.Process_Handle("iw4mp");
		}

		private void InitializeComponent()
		{
			this.label1 = new Label();
			this.label2 = new Label();
			this.numericUpDown1 = new NumericUpDown();
			this.numericUpDown2 = new NumericUpDown();
			this.numericUpDown3 = new NumericUpDown();
			this.numericUpDown4 = new NumericUpDown();
			this.label3 = new Label();
			this.label4 = new Label();
			this.numericUpDown5 = new NumericUpDown();
			this.numericUpDown6 = new NumericUpDown();
			this.label5 = new Label();
			this.label6 = new Label();
			this.checkBox1 = new CheckBox();
			this.checkBox2 = new CheckBox();
			this.checkBox3 = new CheckBox();
			this.checkBox4 = new CheckBox();
			this.checkBox5 = new CheckBox();
			this.checkBox6 = new CheckBox();
			this.label7 = new Label();
			this.label8 = new Label();
			this.label9 = new Label();
			this.label10 = new Label();
			this.label11 = new Label();
			this.label12 = new Label();
			this.checkBox7 = new CheckBox();
			this.checkBox8 = new CheckBox();
			this.checkBox9 = new CheckBox();
			this.checkBox10 = new CheckBox();
			this.checkBox11 = new CheckBox();
			this.checkBox12 = new CheckBox();
			this.numericUpDown7 = new NumericUpDown();
			this.numericUpDown8 = new NumericUpDown();
			this.numericUpDown9 = new NumericUpDown();
			this.numericUpDown10 = new NumericUpDown();
			this.numericUpDown11 = new NumericUpDown();
			this.numericUpDown12 = new NumericUpDown();
			this.checkBox13 = new CheckBox();
			this.numericUpDown13 = new NumericUpDown();
			this.label13 = new Label();
			this.button1 = new Button();
			((ISupportInitialize)this.numericUpDown1).BeginInit();
			((ISupportInitialize)this.numericUpDown2).BeginInit();
			((ISupportInitialize)this.numericUpDown3).BeginInit();
			((ISupportInitialize)this.numericUpDown4).BeginInit();
			((ISupportInitialize)this.numericUpDown5).BeginInit();
			((ISupportInitialize)this.numericUpDown6).BeginInit();
			((ISupportInitialize)this.numericUpDown7).BeginInit();
			((ISupportInitialize)this.numericUpDown8).BeginInit();
			((ISupportInitialize)this.numericUpDown9).BeginInit();
			((ISupportInitialize)this.numericUpDown10).BeginInit();
			((ISupportInitialize)this.numericUpDown11).BeginInit();
			((ISupportInitialize)this.numericUpDown12).BeginInit();
			((ISupportInitialize)this.numericUpDown13).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Location = new Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "XP";
			this.label2.AutoSize = true;
			this.label2.Location = new Point(12, 35);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Prestige";
			this.numericUpDown1.Location = new Point(81, 7);
			NumericUpDown num = this.numericUpDown1;
			int[] numArray = new int[] { 2516000, 0, 0, 0 };
			num.Maximum = new decimal(numArray);
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown1.TabIndex = 2;
			this.numericUpDown2.Location = new Point(81, 33);
			NumericUpDown numericUpDown = this.numericUpDown2;
			numArray = new int[] { 11, 0, 0, 0 };
			numericUpDown.Maximum = new decimal(numArray);
			this.numericUpDown2.Name = "numericUpDown2";
			this.numericUpDown2.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown2.TabIndex = 3;
			this.numericUpDown3.Location = new Point(81, 85);
			NumericUpDown num1 = this.numericUpDown3;
			numArray = new int[] { 999999999, 0, 0, 0 };
			num1.Maximum = new decimal(numArray);
			this.numericUpDown3.Name = "numericUpDown3";
			this.numericUpDown3.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown3.TabIndex = 7;
			this.numericUpDown4.Location = new Point(81, 59);
			NumericUpDown numericUpDown1 = this.numericUpDown4;
			numArray = new int[] { 999999999, 0, 0, 0 };
			numericUpDown1.Maximum = new decimal(numArray);
			this.numericUpDown4.Name = "numericUpDown4";
			this.numericUpDown4.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown4.TabIndex = 6;
			this.label3.AutoSize = true;
			this.label3.Location = new Point(12, 87);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Wins";
			this.label4.AutoSize = true;
			this.label4.Location = new Point(12, 61);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Score";
			this.numericUpDown5.Location = new Point(81, 137);
			NumericUpDown num2 = this.numericUpDown5;
			numArray = new int[] { 999999999, 0, 0, 0 };
			num2.Maximum = new decimal(numArray);
			this.numericUpDown5.Name = "numericUpDown5";
			this.numericUpDown5.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown5.TabIndex = 11;
			this.numericUpDown6.Location = new Point(81, 111);
			NumericUpDown numericUpDown2 = this.numericUpDown6;
			numArray = new int[] { 999999999, 0, 0, 0 };
			numericUpDown2.Maximum = new decimal(numArray);
			this.numericUpDown6.Name = "numericUpDown6";
			this.numericUpDown6.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown6.TabIndex = 10;
			this.label5.AutoSize = true;
			this.label5.Location = new Point(12, 139);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(33, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Ties";
			this.label6.AutoSize = true;
			this.label6.Location = new Point(12, 113);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(46, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Losses";
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new Point(152, 9);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(15, 14);
			this.checkBox1.TabIndex = 12;
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new EventHandler(this.checkBox1_CheckedChanged);
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new Point(152, 35);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(15, 14);
			this.checkBox2.TabIndex = 13;
			this.checkBox2.UseVisualStyleBackColor = true;
			this.checkBox2.CheckedChanged += new EventHandler(this.checkBox2_CheckedChanged);
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new Point(152, 87);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(15, 14);
			this.checkBox3.TabIndex = 15;
			this.checkBox3.UseVisualStyleBackColor = true;
			this.checkBox3.CheckedChanged += new EventHandler(this.checkBox3_CheckedChanged);
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new Point(152, 61);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(15, 14);
			this.checkBox4.TabIndex = 14;
			this.checkBox4.UseVisualStyleBackColor = true;
			this.checkBox4.CheckedChanged += new EventHandler(this.checkBox4_CheckedChanged);
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new Point(152, 139);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(15, 14);
			this.checkBox5.TabIndex = 17;
			this.checkBox5.UseVisualStyleBackColor = true;
			this.checkBox5.CheckedChanged += new EventHandler(this.checkBox5_CheckedChanged);
			this.checkBox6.AutoSize = true;
			this.checkBox6.Location = new Point(152, 113);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(15, 14);
			this.checkBox6.TabIndex = 16;
			this.checkBox6.UseVisualStyleBackColor = true;
			this.checkBox6.CheckedChanged += new EventHandler(this.checkBox6_CheckedChanged);
			this.label7.AutoSize = true;
			this.label7.Location = new Point(193, 139);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(47, 13);
			this.label7.TabIndex = 27;
			this.label7.Text = "Deaths";
			this.label8.AutoSize = true;
			this.label8.Location = new Point(193, 113);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(49, 13);
			this.label8.TabIndex = 26;
			this.label8.Text = "Streaks";
			this.label9.AutoSize = true;
			this.label9.Location = new Point(193, 87);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(45, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "Assists";
			this.label10.AutoSize = true;
			this.label10.Location = new Point(193, 61);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(66, 13);
			this.label10.TabIndex = 22;
			this.label10.Text = "HeadShots";
			this.label11.AutoSize = true;
			this.label11.Location = new Point(193, 35);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(31, 13);
			this.label11.TabIndex = 19;
			this.label11.Text = "Kills";
			this.label12.AutoSize = true;
			this.label12.Location = new Point(193, 9);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(63, 13);
			this.label12.TabIndex = 18;
			this.label12.Text = "WinStreak";
			this.checkBox7.AutoSize = true;
			this.checkBox7.Location = new Point(336, 139);
			this.checkBox7.Name = "checkBox7";
			this.checkBox7.Size = new System.Drawing.Size(15, 14);
			this.checkBox7.TabIndex = 39;
			this.checkBox7.UseVisualStyleBackColor = true;
			this.checkBox7.CheckedChanged += new EventHandler(this.checkBox7_CheckedChanged);
			this.checkBox8.AutoSize = true;
			this.checkBox8.Location = new Point(336, 113);
			this.checkBox8.Name = "checkBox8";
			this.checkBox8.Size = new System.Drawing.Size(15, 14);
			this.checkBox8.TabIndex = 38;
			this.checkBox8.UseVisualStyleBackColor = true;
			this.checkBox8.CheckedChanged += new EventHandler(this.checkBox8_CheckedChanged);
			this.checkBox9.AutoSize = true;
			this.checkBox9.Location = new Point(336, 87);
			this.checkBox9.Name = "checkBox9";
			this.checkBox9.Size = new System.Drawing.Size(15, 14);
			this.checkBox9.TabIndex = 37;
			this.checkBox9.UseVisualStyleBackColor = true;
			this.checkBox9.CheckedChanged += new EventHandler(this.checkBox9_CheckedChanged);
			this.checkBox10.AutoSize = true;
			this.checkBox10.Location = new Point(336, 61);
			this.checkBox10.Name = "checkBox10";
			this.checkBox10.Size = new System.Drawing.Size(15, 14);
			this.checkBox10.TabIndex = 36;
			this.checkBox10.UseVisualStyleBackColor = true;
			this.checkBox10.CheckedChanged += new EventHandler(this.checkBox10_CheckedChanged);
			this.checkBox11.AutoSize = true;
			this.checkBox11.Location = new Point(336, 35);
			this.checkBox11.Name = "checkBox11";
			this.checkBox11.Size = new System.Drawing.Size(15, 14);
			this.checkBox11.TabIndex = 35;
			this.checkBox11.UseVisualStyleBackColor = true;
			this.checkBox11.CheckedChanged += new EventHandler(this.checkBox11_CheckedChanged);
			this.checkBox12.AutoSize = true;
			this.checkBox12.Location = new Point(336, 9);
			this.checkBox12.Name = "checkBox12";
			this.checkBox12.Size = new System.Drawing.Size(15, 14);
			this.checkBox12.TabIndex = 34;
			this.checkBox12.UseVisualStyleBackColor = true;
			this.checkBox12.CheckedChanged += new EventHandler(this.checkBox12_CheckedChanged);
			this.numericUpDown7.Location = new Point(265, 137);
			NumericUpDown num3 = this.numericUpDown7;
			numArray = new int[] { 999999999, 0, 0, 0 };
			num3.Maximum = new decimal(numArray);
			this.numericUpDown7.Name = "numericUpDown7";
			this.numericUpDown7.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown7.TabIndex = 33;
			this.numericUpDown8.Location = new Point(265, 111);
			NumericUpDown numericUpDown3 = this.numericUpDown8;
			numArray = new int[] { 999999999, 0, 0, 0 };
			numericUpDown3.Maximum = new decimal(numArray);
			this.numericUpDown8.Name = "numericUpDown8";
			this.numericUpDown8.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown8.TabIndex = 32;
			this.numericUpDown9.Location = new Point(265, 85);
			NumericUpDown num4 = this.numericUpDown9;
			numArray = new int[] { 999999999, 0, 0, 0 };
			num4.Maximum = new decimal(numArray);
			this.numericUpDown9.Name = "numericUpDown9";
			this.numericUpDown9.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown9.TabIndex = 31;
			this.numericUpDown10.Location = new Point(265, 59);
			NumericUpDown numericUpDown4 = this.numericUpDown10;
			numArray = new int[] { 999999999, 0, 0, 0 };
			numericUpDown4.Maximum = new decimal(numArray);
			this.numericUpDown10.Name = "numericUpDown10";
			this.numericUpDown10.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown10.TabIndex = 30;
			this.numericUpDown11.Location = new Point(265, 33);
			NumericUpDown num5 = this.numericUpDown11;
			numArray = new int[] { 999999999, 0, 0, 0 };
			num5.Maximum = new decimal(numArray);
			this.numericUpDown11.Name = "numericUpDown11";
			this.numericUpDown11.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown11.TabIndex = 29;
			this.numericUpDown12.Location = new Point(265, 7);
			NumericUpDown numericUpDown5 = this.numericUpDown12;
			numArray = new int[] { 999999999, 0, 0, 0 };
			numericUpDown5.Maximum = new decimal(numArray);
			this.numericUpDown12.Name = "numericUpDown12";
			this.numericUpDown12.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown12.TabIndex = 28;
			this.checkBox13.AutoSize = true;
			this.checkBox13.Location = new Point(152, 165);
			this.checkBox13.Name = "checkBox13";
			this.checkBox13.Size = new System.Drawing.Size(15, 14);
			this.checkBox13.TabIndex = 42;
			this.checkBox13.UseVisualStyleBackColor = true;
			this.checkBox13.CheckedChanged += new EventHandler(this.checkBox13_CheckedChanged);
			this.numericUpDown13.Location = new Point(81, 163);
			NumericUpDown num6 = this.numericUpDown13;
			numArray = new int[] { 999999999, 0, 0, 0 };
			num6.Maximum = new decimal(numArray);
			this.numericUpDown13.Name = "numericUpDown13";
			this.numericUpDown13.Size = new System.Drawing.Size(65, 20);
			this.numericUpDown13.TabIndex = 41;
			this.label13.AutoSize = true;
			this.label13.Location = new Point(12, 165);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(63, 13);
			this.label13.TabIndex = 40;
			this.label13.Text = "Accolades";
			this.button1.Location = new Point(196, 163);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(155, 23);
			this.button1.TabIndex = 43;
			this.button1.Text = "UNLOCK ALL";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new EventHandler(this.button1_Click);
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new System.Drawing.Size(363, 191);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.checkBox13);
			base.Controls.Add(this.numericUpDown13);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.checkBox7);
			base.Controls.Add(this.checkBox8);
			base.Controls.Add(this.checkBox9);
			base.Controls.Add(this.checkBox10);
			base.Controls.Add(this.checkBox11);
			base.Controls.Add(this.checkBox12);
			base.Controls.Add(this.numericUpDown7);
			base.Controls.Add(this.numericUpDown8);
			base.Controls.Add(this.numericUpDown9);
			base.Controls.Add(this.numericUpDown10);
			base.Controls.Add(this.numericUpDown11);
			base.Controls.Add(this.numericUpDown12);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.checkBox5);
			base.Controls.Add(this.checkBox6);
			base.Controls.Add(this.checkBox3);
			base.Controls.Add(this.checkBox4);
			base.Controls.Add(this.checkBox2);
			base.Controls.Add(this.checkBox1);
			base.Controls.Add(this.numericUpDown5);
			base.Controls.Add(this.numericUpDown6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.numericUpDown3);
			base.Controls.Add(this.numericUpDown4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.numericUpDown2);
			base.Controls.Add(this.numericUpDown1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(379, 230);
			this.MinimumSize = new System.Drawing.Size(379, 230);
			base.Name = "Form2";
			base.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "WiiZARDD'S STAT MODIFIER";
			base.Load += new EventHandler(this.Form2_Load);
			((ISupportInitialize)this.numericUpDown1).EndInit();
			((ISupportInitialize)this.numericUpDown2).EndInit();
			((ISupportInitialize)this.numericUpDown3).EndInit();
			((ISupportInitialize)this.numericUpDown4).EndInit();
			((ISupportInitialize)this.numericUpDown5).EndInit();
			((ISupportInitialize)this.numericUpDown6).EndInit();
			((ISupportInitialize)this.numericUpDown7).EndInit();
			((ISupportInitialize)this.numericUpDown8).EndInit();
			((ISupportInitialize)this.numericUpDown9).EndInit();
			((ISupportInitialize)this.numericUpDown10).EndInit();
			((ISupportInitialize)this.numericUpDown11).EndInit();
			((ISupportInitialize)this.numericUpDown12).EndInit();
			((ISupportInitialize)this.numericUpDown13).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}
	}
}