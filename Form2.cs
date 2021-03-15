using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Ph
{
	public partial class Form2 : Form
	{
		public Bitmap img = null;
		public Form2()
		{
			InitializeComponent();
			img = new Bitmap(pictureBox1.Width, pictureBox1.Height);
			pictureBox1.Image = img;
		}
		private void pictureBox1_Click(object sender, EventArgs e)//клик на картиночку
		{
			openImg(); //открытие изображения
		}
		public int trackBar1_Int(int redd)
		{
			int red = trackBar1.Value * 30 + redd;
			if (red <= 255 && red >= 0)
				return red;
			else if (red > 255)
				return 255;
			else return 0;
		}
		protected int trackBar2_Int(int greenn)
		{
			int green = trackBar2.Value * 30 + greenn;
			if (green <= 255 && green >= 0)
				return green;
			else if (green > 255)
				return 255;
			else return 0;
		}
		private int trackBar3_Int(int bluee)
		{
			int blue = trackBar3.Value * 30 + bluee;
			if (blue <= 255 && blue >= 0)
				return blue;
			else if (blue > 255)
				return 255;
			else return 0;
		}
		private void openImg()
		{
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
			openFileDialog.Filter = "Картинки (png, jpg, bmp, gif) |*.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (img != null)
				{
					pictureBox1.Image = null;
					img.Dispose();
				}
				img = new Bitmap(openFileDialog.FileName);
				pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
				pictureBox1.Image = img; // помещаем картинку в окошко где она должна валятся
			}

		}
		#region
		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void trackBar1_Scroll(object sender, EventArgs e)
		{
			
		}
		#endregion
		private void button1_Click(object sender, EventArgs e) // клик по моей кнопке изменения
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			for (int i = 0; i < img.Height; ++i)
			{
				for (int j = 0; j < img.Width; ++j)
				{
					var pix = img.GetPixel(j, i);

					int r = pix.R;
					int g = pix.G;
					int b = pix.B;

					r = trackBar1_Int(r);
					g = trackBar2_Int(g);
					b = trackBar3_Int(b);

					pix = Color.FromArgb(r, g, b);
					img.SetPixel(j, i, pix);

				}
			}
			stopwatch.Stop();
			label4.Text = Convert.ToString(stopwatch.ElapsedMilliseconds) + " ms";
			pictureBox1.Refresh();
			trackBar1.Value = 0;
			trackBar2.Value = 0;
			trackBar3.Value = 0;
			
		}
	}
}
