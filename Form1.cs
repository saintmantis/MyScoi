using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Ph
{
	public partial class Form1 : Form
	{
		public Bitmap img1 = null;
		public Bitmap img2 = null;
		public Bitmap img_out = null;
		public Form1()
		{
			InitializeComponent();
		}
		private void image1_Click(object sender, EventArgs e) // загрузка первой картинки
		{
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
			openFileDialog.Filter = "Картинки (png, jpg, bmp, gif) |*.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (img1 != null)
				{
					image1.Image = null;
					img1.Dispose();
				}

				img1 = new Bitmap(openFileDialog.FileName);
				image1.SizeMode = PictureBoxSizeMode.StretchImage;
				image1.Image = img1; // помещаем картинку в окошко где она должна валятся
			}
		}
		private void image2_Click(object sender, EventArgs e) // загрузка второй картинки
		{
			using OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.InitialDirectory = Directory.GetCurrentDirectory();
			openFileDialog.Filter = "Картинки (png, jpg, bmp, gif) |*.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
			openFileDialog.RestoreDirectory = true;
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				if (img2 != null)
				{
					image2.Image = null;
					img2.Dispose();
				}

				img2 = new Bitmap(openFileDialog.FileName);
				image2.SizeMode = PictureBoxSizeMode.StretchImage;
				image2.Image = img2; // помещаем картинку в окошко где она должна валятся
			}
		}
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			stretchingPictures();//вызов функции которая делает изображения одного размера
			string myAction = comboBox1.Text;
			switch (myAction)
			{
				case "Pixel sum":
					pixelSum();//pixelSum();// вызов функции сложения
					break;
				case "Pixel multiplication":
					pixelMultiplication();// вызов функции умножения
					break;
				case "Pixel arithmetic mean":
					pixelAritmeticMean();// вызов функции среднего арифметического
					break;
				case "Pixel minimum":
					pixelMinimum();// пиксельный минимум
					break;
				case "Pixel maximum":
					pixelMaximum();//пиксельный максимум
					break;
				case "Mask square":
					maskSquare();//маска квадрат
					break;
				case "Mask rectangle":
					maskRectangle();//маска прямоугольник
					break;
				case "Mask circle":
					maskCircle();//маска круг
					break;
				default:
					Console.WriteLine("default");
					break;
			}
			stopwatch.Stop();
			label5.Text = Convert.ToString(stopwatch.ElapsedMilliseconds) + " ms";
			SaveImg(img_out);
		}
		private void stretchingPictures()//функция подгона изображения по размеру
		{
			if (img1.Width > img2.Width)// если первая картинка больше второй по ширине
			{
				Bitmap img22 = new Bitmap(img2, new Size(img1.Width, img1.Height));
				img2 = img22;
			}
			if (img1.Width < img2.Width)// если вторая картинка больше первой по ширине
			{
				Bitmap img11 = new Bitmap(img1, new Size(img2.Width, img2.Height));
				img1 = img11;
			}
			if (img1.Height > img2.Height)//если высота первой картинки больше высоты второй
			{
				Bitmap img22 = new Bitmap(img2, new Size(img1.Width, img1.Height));//растягиваем вторую картинку до высоты первой
				img2 = img22;
			}
			if (img2.Height > img1.Height)//если высота второй картинки больше высоты первой
			{
				Bitmap img11 = new Bitmap(img1, new Size(img2.Width, img2.Height)); //растягиваем первую картинку до высоты второй
				img1 = img11;
			}
		}
		private void maskSquare()
		{
			int widthImage1 = img1.Width;
			int heightImage1 = img1.Height;
			img_out = new Bitmap(img1.Width, img1.Height);
			int center_x = img2.Width / 2;
			int center_y = img2.Height / 2;
			int расстояние_отступа = (img2.Height / 5);

			for (int i = 0; i < heightImage1; i++)
			{
				for (int j = 0; j < widthImage1; j++)
				{
					// в начале находим среднее ширину потом высоту и находим средний пиксель
					// затем делаем квадратное окно относительно масшатабов картинки
					var pix1 = img1.GetPixel(j, i);
					int r = pix1.R;
					int g = pix1.G;
					int b = pix1.B;

					if ((j < center_x - расстояние_отступа) || (j > center_x + расстояние_отступа) || (i > center_y + расстояние_отступа) || (i < center_y - расстояние_отступа)) // печатать вторую фотку все кроме ограничений
					{
						var pix2 = img2.GetPixel(j, i);
						r = pix2.R;
						g = pix2.G;
						b = pix2.B;
					}
					// записываем пиксель в изображение
					var pix = Color.FromArgb(r, g, b);
					img_out.SetPixel(j, i, pix);
				}
			}
		} // квадрат
		private void maskRectangle()
		{
			int widthImage1 = img1.Width;
			int heightImage1 = img1.Height;
			img_out = new Bitmap(img1.Width, img1.Height);
			int center_x = img2.Width / 2;
			int center_y = img2.Height / 2;
			int вверхняя_граница_прямоугольника = center_y + (img2.Height / 4);
			int нижняя_граница_прямоугольника = center_y - (img2.Height / 4);
			int лево = center_x - (img2.Width / 4);
			int прав = center_x + (img2.Width / 4);

			for (int i = 0; i < img1.Height; i++)
			{
				for (int j = 0; j < img1.Width; j++)
				{
					// в начале находим среднее ширину потом высоту и находим средний пиксель
					// затем делаем прямоугольное окно относительно масшатабов картинки
					var pix1 = img1.GetPixel(j, i);
					int r = pix1.R;
					int g = pix1.G;
					int b = pix1.B;

					if ((j < лево) || (j > прав) || (i > вверхняя_граница_прямоугольника) || (i < нижняя_граница_прямоугольника)) // печатать вторую фотку все кроме ограничений
					{
						var pix2 = img2.GetPixel(j, i);
						r = pix2.R;
						g = pix2.G;
						b = pix2.B;
					}
					// записываем пиксель в изображение
					var pix = Color.FromArgb(r, g, b);
					img_out.SetPixel(j, i, pix);
				}
			}
		} // Прямоугольник
		private void maskCircle()
		{
			int widthImage1 = img1.Width;
			int heightImage1 = img1.Height;
			img_out = new Bitmap(img1.Width, img1.Height);
			int center_x = img2.Width / 2; // центр по ширине
			int center_y = img2.Height / 2; // центр по высоте
			int radius = img2.Width / 8;
			for (int i = 0; i < img1.Height; i++)
			{
				for (int j = 0; j < img1.Width; j++)
				{
					// в начале находим среднее ширину потом высоту и находим средний пиксель
					// затем делаем квадратное окно относительно масшатабов картинки
					var pix1 = img1.GetPixel(j, i);
					int r = pix1.R;
					int g = pix1.G;
					int b = pix1.B;
					//находим точку на окружности
					double res = Math.Pow(j - center_x, 2) + Math.Pow(i - center_y, 2);

					if (res <= Math.Pow(radius, 2))
					{
						var pix2 = img2.GetPixel(j, i);
						r = pix2.R;
						g = pix2.G;
						b = pix2.B;
					}
					// записываем пиксель в изображение
					var pix = Color.FromArgb(r, g, b);
					img_out.SetPixel(j, i, pix);
				}
			}
		} // круг
		private void pixelSum()
		{
			int widthImage1 = img1.Width;
			int heightImage1 = img1.Height;
			img_out = new Bitmap(img1.Width, img1.Height);

			for (int i = 0; i < img1.Height; i++)
			{
				for (int j = 0; j < img1.Width; j++)
				{
					var pix1 = img1.GetPixel(j, i);
					int r1 = pix1.R;
					int g1 = pix1.G;
					int b1 = pix1.B;

					//читаем пиксель второй картинки
					var pix2 = img2.GetPixel(j, i);
					int r2 = pix2.R;
					int g2 = pix2.G;
					int b2 = pix2.B;

					//первое задание
					int r = r1 + r2;
					if (r > 255) { r = 255; }
					int g = g1 + g2;
					if (g > 255) { g = 255; }
					int b = b1 + b2;
					if (b > 255) { b = 255; }

					// записываем пиксель в изображение
					var pix = Color.FromArgb(r, g, b);
					img_out.SetPixel(j, i, pix);
				}
			}
		}
		private void pixelMaximum()
		{
			int widthImage1 = img1.Width;
			int heightImage1 = img1.Height;
			img_out = new Bitmap(img1.Width, img1.Height);

			for (int i = 0; i < img1.Height; i++)
			{
				for (int j = 0; j < img1.Width; j++)
				{
					//читаем пиксель первой картинки
					var pix1 = img1.GetPixel(j, i);
					int r1 = pix1.R;
					int g1 = pix1.G;
					int b1 = pix1.B;

					//читаем пиксель второй картинки
					var pix2 = img2.GetPixel(j, i);
					int r2 = pix2.R;
					int g2 = pix2.G;
					int b2 = pix2.B;

					//максимум
					int r, g, b;
					if (r1 > r2)
					{
						r = r1;
					}
					else { r = r2; }
					if (g1 > g2)
					{
						g = g1;

					}
					else { g = g2; }
					if (b1 > b2)
					{
						b = b1;
					}
					else { b = b2; }

					// записываем пиксель в изображение
					var pix = Color.FromArgb(r, g, b);
					img_out.SetPixel(j, i, pix);
				}
			}
		}
		private void pixelMinimum()
		{
			int widthImage1 = img1.Width;
			int heightImage1 = img1.Height;
			img_out = new Bitmap(img1.Width, img1.Height);

			for (int i = 0; i < img1.Height; i++)
			{
				for (int j = 0; j < img1.Width; j++)
				{
					//читаем пиксель первой картинки
					var pix1 = img1.GetPixel(j, i);
					int r1 = pix1.R;
					int g1 = pix1.G;
					int b1 = pix1.B;

					//читаем пиксель второй картинки
					var pix2 = img2.GetPixel(j, i);
					int r2 = pix2.R;
					int g2 = pix2.G;
					int b2 = pix2.B;

					//минимум
					int r, g, b;
					if (r1 > r2)
					{
						r = r2;
					}
					else { r = r1; }
					if (g1 > g2)
					{
						g = g2;

					}
					else { g = g1; }
					if (b1 > b2)
					{
						b = b2;
					}
					else { b = b1; }

					// записываем пиксель в изображение
					var pix = Color.FromArgb(r, g, b);
					img_out.SetPixel(j, i, pix);
				}
			}
		}
		private void pixelMultiplication()
		{
			int widthImage1 = img1.Width;
			int heightImage1 = img1.Height;
			img_out = new Bitmap(img1.Width, img1.Height);

			for (int i = 0; i < heightImage1; i++)
			{
				for (int j = 0; j < widthImage1; ++j)
				{
					//читаем пиксель первой картинки
					var pix1 = img1.GetPixel(j, i);
					int r1 = pix1.R;
					int g1 = pix1.G;
					int b1 = pix1.B;

					//читаем пиксель второй картинки
					var pix2 = img2.GetPixel(j, i);
					int r2 = pix2.R;
					int g2 = pix2.G;
					int b2 = pix2.B;

					//второе задание
					int r = r1 * r2;
					if (r > 255) { r = 255; }
					int g = g1 * g2;
					if (g > 255) { g = 255; }
					int b = b1 * b2;
					if (b > 255) { b = 255; }

					// записываем пиксель в изображение
					var pix = Color.FromArgb(r, g, b);
					img_out.SetPixel(j, i, pix);
				}
			}	 
		}
		private void SaveImg(Bitmap img_out) // функция сохранения
		{
			using SaveFileDialog saveFileFialog = new SaveFileDialog();
			saveFileFialog.InitialDirectory = Directory.GetCurrentDirectory();
			saveFileFialog.Filter = "Картинки (png, jpg, bmp, gif) |*.png;*.jpg;*.bmp;*.gif|All files (*.*)|*.*";
			saveFileFialog.RestoreDirectory = true;

			if (saveFileFialog.ShowDialog() == DialogResult.OK)
			{
				if (img_out != null)
				{
					img_out.Save(saveFileFialog.FileName);
				}
			}
			imageResult.SizeMode = PictureBoxSizeMode.StretchImage;
			imageResult.Image = img_out; // помещаем картинку в окошко где она должна валятся
		}
		private void pixelAritmeticMean()
		{
			int widthImage1 = img1.Width;
			int heightImage1 = img1.Height;
			img_out = new Bitmap(img1.Width, img1.Height);

			for (int i = 0; i < heightImage1; i++)
			{
				for (int j = 0; j < widthImage1; j++)
				{
					//читаем пиксель первой картинки
					var pix1 = img1.GetPixel(j, i);
					int r1 = pix1.R;
					int g1 = pix1.G;
					int b1 = pix1.B;

					//читаем пиксель второй картинки
					var pix2 = img2.GetPixel(j, i);
					int r2 = pix2.R;
					int g2 = pix2.G;
					int b2 = pix2.B;

					//второе задание
					int r = r1 + r2;
					int g = g1 + g2;
					int b = b1 + b2;

					r = (int)Clamp(r * 0.5, 0, 255);
					g = (int)Clamp(g * 0.5, 0, 255);
					b = (int)Clamp(b * 0.5, 0, 255);
					// записываем пиксель в изображение
					var pix = Color.FromArgb(r, g, b);
					img_out.SetPixel(j, i, pix);
				}
			}
		}
		public static T Clamp<T>(T val, T min, T max) where T : IComparable<T>
		{
			if (val.CompareTo(min) < 0) return min;
			else if (val.CompareTo(max) > 0) return max;
			else return val;
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Form2 dlg = new Form2();
			dlg.Show(this);
		}
		private void TransparencyPictures() // прозрачность
		{
			Stopwatch stopwatch = new Stopwatch();
			stopwatch.Start();
			img_out = (Bitmap)imageResult.Image;
			int myAlpha = trackBar1.Value;
			int widthImage1 = img_out.Width;
			int heightImage1 = img_out.Height;

			for (int i = 0; i < heightImage1; i++)
			{
				for (int j = 0; j < widthImage1; ++j)
				{
					//читаем пиксель первой картинки
					var pix1 = img_out.GetPixel(j, i);

					int a = (int)Clamp(pix1.A * myAlpha * 0.1, 0, 255);
					int r = pix1.R;
					int g = pix1.G;
					int b = pix1.B;
					var pix = Color.FromArgb(a, r, g, b);
					img_out.SetPixel(j, i, pix);
				}
			}
			stopwatch.Stop();
			label5.Text = Convert.ToString(stopwatch.ElapsedMilliseconds) + " ms";
			SaveImg(img_out);
		}
		private void button2_Click(object sender, EventArgs e)
		{
			TransparencyPictures();
		}
	}
}
