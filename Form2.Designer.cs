
namespace Ph
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.trackBar2 = new System.Windows.Forms.TrackBar();
			this.trackBar3 = new System.Windows.Forms.TrackBar();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(117, 12);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(620, 407);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(238, 480);
			this.trackBar1.Maximum = 5;
			this.trackBar1.Minimum = -5;
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(382, 45);
			this.trackBar1.TabIndex = 1;
			this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
			// 
			// trackBar2
			// 
			this.trackBar2.Location = new System.Drawing.Point(238, 555);
			this.trackBar2.Maximum = 5;
			this.trackBar2.Minimum = -5;
			this.trackBar2.Name = "trackBar2";
			this.trackBar2.Size = new System.Drawing.Size(382, 45);
			this.trackBar2.TabIndex = 2;
			// 
			// trackBar3
			// 
			this.trackBar3.Location = new System.Drawing.Point(238, 626);
			this.trackBar3.Maximum = 5;
			this.trackBar3.Minimum = -5;
			this.trackBar3.Name = "trackBar3";
			this.trackBar3.Size = new System.Drawing.Size(382, 45);
			this.trackBar3.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Red;
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(158, 480);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 15);
			this.label1.TabIndex = 4;
			this.label1.Text = "Red";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Green;
			this.label2.ForeColor = System.Drawing.Color.White;
			this.label2.Location = new System.Drawing.Point(158, 555);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(38, 15);
			this.label2.TabIndex = 5;
			this.label2.Text = "Green";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Blue;
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(158, 626);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(30, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Blue";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(334, 677);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(187, 40);
			this.button1.TabIndex = 7;
			this.button1.Text = "RGB";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.White;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label4.Location = new System.Drawing.Point(410, 422);
			this.label4.MaximumSize = new System.Drawing.Size(10000, 21);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(41, 21);
			this.label4.TabIndex = 8;
			this.label4.Text = "0 ms";
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(847, 729);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.trackBar3);
			this.Controls.Add(this.trackBar2);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.pictureBox1);
			this.Name = "Form2";
			this.Text = "ColorChannels";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.TrackBar trackBar2;
		private System.Windows.Forms.TrackBar trackBar3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label4;
	}
}