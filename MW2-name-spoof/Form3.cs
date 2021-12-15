using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Stuff
{
	public class Form3 : Form
	{
		private MemoryClass nonHost = new MemoryClass();

		private IContainer components = null;

		private CheckBox checkBox1;

		private CheckBox checkBox2;

		private CheckBox checkBox3;

		private CheckBox checkBox4;

		public Form3()
		{
			this.InitializeComponent();
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			byte[] numArray;
			if (!this.checkBox1.Checked)
			{
				numArray = new byte[] { 116 };
				this.nonHost.WriteBytes32(4752805, numArray);
			}
			else
			{
				numArray = new byte[] { 117 };
				this.nonHost.WriteBytes32(4752805, numArray);
			}
		}

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{
			byte[] numArray;
			if (!this.checkBox2.Checked)
			{
				numArray = new byte[] { 116 };
				this.nonHost.WriteBytes32(4956107, numArray);
			}
			else
			{
				numArray = new byte[] { 117 };
				this.nonHost.WriteBytes32(4956107, numArray);
			}
		}

		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			byte[] numArray;
			if (!this.checkBox3.Checked)
			{
				numArray = new byte[] { 2 };
				this.nonHost.WriteBytes32(4694442, numArray);
			}
			else
			{
				numArray = new byte[1];
				this.nonHost.WriteBytes32(4694442, numArray);
			}
		}

		private void checkBox4_CheckedChanged(object sender, EventArgs e)
		{
			byte[] numArray;
			if (!this.checkBox4.Checked)
			{
				numArray = new byte[] { 1 };
				this.nonHost.WriteBytes32(4694647, numArray);
			}
			else
			{
				numArray = new byte[1];
				this.nonHost.WriteBytes32(4694647, numArray);
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

		private void Form3_Load(object sender, EventArgs e)
		{
			this.nonHost.Process_Handle("iw4mp");
		}

		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(70, 18);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "RedBox";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox2.Location = new System.Drawing.Point(12, 32);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 18);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Jail Host";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox3.Location = new System.Drawing.Point(199, 14);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(127, 18);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "No Weapon Spread";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBox4.Location = new System.Drawing.Point(199, 32);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(148, 18);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Weapon Spread (Funny)";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(363, 103);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(379, 142);
            this.MinimumSize = new System.Drawing.Size(379, 142);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WiiZARDD\'S RCE MENU";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
	}
}