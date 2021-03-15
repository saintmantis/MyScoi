
namespace Ph
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.imageResult = new System.Windows.Forms.PictureBox();
			this.image1 = new System.Windows.Forms.PictureBox();
			this.image2 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.trackBar1 = new System.Windows.Forms.TrackBar();
			this.label6 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.imageResult)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.image1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.image2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
			this.SuspendLayout();
			// 
			// imageResult
			// 
			this.imageResult.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.imageResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.imageResult.Location = new System.Drawing.Point(174, 213);
			this.imageResult.Name = "imageResult";
			this.imageResult.Size = new System.Drawing.Size(720, 500);
			this.imageResult.TabIndex = 1;
			this.imageResult.TabStop = false;
			// 
			// image1
			// 
			this.image1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.image1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.image1.Location = new System.Drawing.Point(174, 42);
			this.image1.Name = "image1";
			this.image1.Size = new System.Drawing.Size(160, 120);
			this.image1.TabIndex = 4;
			this.image1.TabStop = false;
			this.image1.Click += new System.EventHandler(this.image1_Click);
			// 
			// image2
			// 
			this.image2.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.image2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.image2.Location = new System.Drawing.Point(378, 43);
			this.image2.Name = "image2";
			this.image2.Size = new System.Drawing.Size(160, 120);
			this.image2.TabIndex = 5;
			this.image2.TabStop = false;
			this.image2.Click += new System.EventHandler(this.image2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(174, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 15);
			this.label1.TabIndex = 6;
			this.label1.Text = "image1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(378, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 15);
			this.label2.TabIndex = 7;
			this.label2.Text = "image2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(604, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 15);
			this.label3.TabIndex = 9;
			this.label3.Text = "Select operation";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
            "Pixel sum",
            "Pixel multiplication",
            "Pixel arithmetic mean",
            "Pixel minimum",
            "Pixel maximum",
            "Mask square",
            "Mask rectangle",
            "Mask circle"});
			this.comboBox1.Location = new System.Drawing.Point(604, 43);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(159, 23);
			this.comboBox1.TabIndex = 10;
			this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(174, 195);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 15);
			this.label4.TabIndex = 11;
			this.label4.Text = "Result";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.button1.Location = new System.Drawing.Point(604, 121);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(135, 41);
			this.button1.TabIndex = 12;
			this.button1.Text = "Сolor channels";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.White;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label5.Location = new System.Drawing.Point(772, 718);
			this.label5.MaximumSize = new System.Drawing.Size(1000, 21);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(41, 21);
			this.label5.TabIndex = 13;
			this.label5.Text = "0 ms";
			// 
			// trackBar1
			// 
			this.trackBar1.Location = new System.Drawing.Point(249, 724);
			this.trackBar1.Name = "trackBar1";
			this.trackBar1.Size = new System.Drawing.Size(229, 45);
			this.trackBar1.TabIndex = 14;
			this.trackBar1.Value = 10;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(174, 724);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(79, 15);
			this.label6.TabIndex = 15;
			this.label6.Text = "Transparency:";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.button2.Location = new System.Drawing.Point(484, 718);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(87, 42);
			this.button2.TabIndex = 16;
			this.button2.Text = "make transparent";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1049, 767);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.trackBar1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.image2);
			this.Controls.Add(this.image1);
			this.Controls.Add(this.imageResult);
			this.Name = "Form1";
			this.Text = "PhotoShop";
			((System.ComponentModel.ISupportInitialize)(this.imageResult)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.image1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.image2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox imageResult;
		private System.Windows.Forms.PictureBox image1;
		private System.Windows.Forms.PictureBox image2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TrackBar trackBar1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button2;
	}
}

