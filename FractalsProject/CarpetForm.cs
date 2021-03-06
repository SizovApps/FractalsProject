using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalsProject
{
    public partial class CarpetForm : Form
    {
        // Сюда записываем наш рисунок.
        Bitmap bitmap;
        Graphics graphics;
        CarpetFractal carpetFractal;

        // Начальный и конечный цвет градиента.
        Color startColor;
        Color endColor;

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public CarpetForm()
        {
            InitializeComponent();
            startColor = Color.Black;
            endColor = Color.Black;
        }

        /// <summary>
        /// Обновляем рисунок и параметры при изменении размеров экрана.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CarpetForm_Resize(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                widthOfLineTrack.Maximum = this.Width / 2 - 20;
                heightOfLineTrack.Maximum = this.Width / 2 - 20;
                paintPanel.Width = this.Width / 2;
                return;
            }

            widthOfLineTrack.Maximum = this.Width/2 - 20;
            heightOfLineTrack.Maximum = this.Width/2 - 20;
            paintPanel.Width = this.Width / 2;

            CarpetFractal carpetFractal = new CarpetFractal(widthOfLineTrack.Value, heightOfLineTrack.Value, numOnRecursionTrack.Value);
            bitmap = new Bitmap(paintPanel.Width, paintPanel.Height);
            graphics = Graphics.FromImage(bitmap);
            RectangleF rectangle = new RectangleF(paintPanel.Width / 2 - widthOfLineTrack.Value / 2, paintPanel.Height / 2 - heightOfLineTrack.Value / 2,
                widthOfLineTrack.Value, heightOfLineTrack.Value);
            IEnumerable<Color> colors = GetGradients(startColor, endColor, numOnRecursionTrack.Value);
            carpetFractal.DrawFractal(graphics, paintPanel, rectangle, 1, colors);

            paintPanel.BackgroundImage = bitmap;
        }

        private void widthOfLineTrack_ValueChanged(object sender, EventArgs e)
        {
            valueOfWidthTrack.Text = widthOfLineTrack.Value.ToString();
        }

        private void heightOfLineTrack_ValueChanged(object sender, EventArgs e)
        {
            valueOfHeightTrack.Text = heightOfLineTrack.Value.ToString();
        }

        private void numOnRecursionTrack_ValueChanged(object sender, EventArgs e)
        {
            valueOfRecursion.Text = numOnRecursionTrack.Value.ToString();
        }

        /// <summary>
        /// Закрываем эту форму и возвращаемся в главное меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = (Form1)Application.OpenForms[0];
            form1.Width = this.Width;
            form1.Height = this.Height;
            form1.StartPosition = FormStartPosition.Manual;
            form1.Top = this.Top;
            form1.Left = this.Left;
            form1.WindowState = this.WindowState;
            form1.Show();
        }

        /// <summary>
        /// Рисуем ковер по клику на кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawButton_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(paintPanel.Width, paintPanel.Height);
            graphics = Graphics.FromImage(bitmap);

            CarpetFractal carpetFractal = new CarpetFractal(widthOfLineTrack.Value, heightOfLineTrack.Value, numOnRecursionTrack.Value);
            RectangleF rectangle = new RectangleF(paintPanel.Width / 2 - widthOfLineTrack.Value / 2, paintPanel.Height / 2 - heightOfLineTrack.Value / 2,
                widthOfLineTrack.Value, heightOfLineTrack.Value);
            IEnumerable<Color> colors = GetGradients(startColor, endColor, numOnRecursionTrack.Value);
            carpetFractal.DrawFractal(graphics, paintPanel, rectangle, 1, colors);

            paintPanel.BackgroundImage = bitmap;
        }

        /// <summary>
        /// Выбираем цвета для градиента.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void useColor_Click(object sender, EventArgs e)
        {
            bool isEnd = true;
            MessageBox.Show("Выберете начальный цвет: ");
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                startColor = colorDialog1.Color;
            }
            else
            {
                isEnd = false;
                startColor = Color.Black;
                endColor = Color.Black;
            }
            MessageBox.Show("Выберете конечный цвет: ");
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                endColor = colorDialog1.Color;
            }
            else
            {
                isEnd = false;
                startColor = Color.Black;
                endColor = Color.Black;
            }
            if (isEnd)
            {
                MessageBox.Show("Градиент выбран!");
            }
        }

        /// <summary>
        /// Получаем список цветов в градиенте.
        /// </summary>
        /// <param name="start">Начальный цвет</param>
        /// <param name="end">Конечный цвет</param>
        /// <param name="steps">Количетсво шагов рекурсии</param>
        /// <returns>Список цветов в градиенте</returns>
        public static IEnumerable<Color> GetGradients(Color start, Color end, int steps)
        {
            if (steps == 2)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (i == 0)
                    {
                        yield return start;
                    }
                    else
                    {
                        yield return end;
                    }
                }
            }
            else if (steps == 1)
            {
                yield return start;
            }
            else
            {
                int stepA = ((end.A - start.A) / (steps - 1));
                int stepR = ((end.R - start.R) / (steps - 1));
                int stepG = ((end.G - start.G) / (steps - 1));
                int stepB = ((end.B - start.B) / (steps - 1));

                for (int i = 0; i < steps; i++)
                {
                    yield return Color.FromArgb(start.A + (stepA * i),
                                                start.R + (stepR * i),
                                                start.G + (stepG * i),
                                                start.B + (stepB * i));
                }
            }
            
        }

        /// <summary>
        /// Сохраняем рисунок в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFractal_Click(object sender, EventArgs e)
        {
            try
            {
                bitmap.Save(saveName.Text + ".jpeg");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не получилось создать файл с таким именем.");
            }
        }
    }
}
