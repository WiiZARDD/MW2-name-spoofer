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
        private Button button2;
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
        private Button button3;
        private EventHandler button2_Click;
        private EventHandler label1_Click;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.RTE = new System.Windows.Forms.Timer(this.components);
            this.Flash = new System.Windows.Forms.Timer(this.components);
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.RankL = new System.Windows.Forms.Timer(this.components);
            this.PrestigeL = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.MaxLength = 32;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(339, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(51, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Spoof Name";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton1.Location = new System.Drawing.Point(12, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(53, 18);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.Text = "RTE";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton2.Location = new System.Drawing.Point(12, 79);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(87, 18);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "Name Flash";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // RTE
            // 
            this.RTE.Tick += new System.EventHandler(this.RTE_Tick);
            // 
            // Flash
            // 
            this.Flash.Tick += new System.EventHandler(this.Flash_Tick);
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.AutoSize = true;
            this.radioButton3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.radioButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.radioButton3.Checked = true;
            this.radioButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.radioButton3.Location = new System.Drawing.Point(12, 62);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 18);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Normal";
            this.radioButton3.UseVisualStyleBackColor = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.checkBox1.Location = new System.Drawing.Point(169, 62);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Rank Cycler";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox2.Location = new System.Drawing.Point(263, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(93, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Prestige Cycler";
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // RankL
            // 
            this.RankL.Tick += new System.EventHandler(this.RankL_Tick);
            // 
            // PrestigeL
            // 
            this.PrestigeL.Tick += new System.EventHandler(this.PrestigeL_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(243, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(246, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "RCE SHIT";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(363, 135);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(379, 174);
            this.MinimumSize = new System.Drawing.Size(379, 174);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MW2 NAME SPOOFER BY WiiZARDD";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		private void Button3_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Welcome to WiiZARDD'S RCE Menu. \n I would like to say, Missouri's old RCE contained \n CiD Rippers and Skid Trappers, so I have \n Released a SOLID build. - WiZ", "MW2 RCE [PUBLIC]", MessageBoxButtons.OK, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
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

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Welcome to WiiZARDD'S RCE Menu. \n I would like to say, Missouri's old RCE contained \n CiD Rippers and Skid Trappers, so I have \n Released a SOLID build. - WiZ", "MW2 RCE [PUBLIC]", MessageBoxButtons.OK, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
            {
                (new Form3()).Show();
            }
            else
            {
                (new Form2()).Show();
            }
    }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}