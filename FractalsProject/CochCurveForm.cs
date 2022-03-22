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
    public partial class CochCurveForm : Form
    {
        // Сюда записываем наш рисунок.
        Bitmap bitmap;
        Graphics graphics;
        CochCurve cochCurve;

        // Начальный и конечный цвет градиента.
        Color startColor;
        Color endColor;

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public CochCurveForm()
        {
            InitializeComponent();
            widthOfLineTrack.Maximum = this.Width / 2;
            paintPanel.Width = this.Width / 2;
            startColor = Color.Black;
            endColor = Color.Black;
        }

        /// <summary>
        /// Обновляем рисунок и параметры при изменении размеров экрана.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CochCurveForm_Resize(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                widthOfLineTrack.Maximum = this.Width / 2 - 20;
                paintPanel.Width = this.Width / 2;
                valueOfWidthTrack.Text = widthOfLineTrack.Value.ToString();
                valueOfRecursion.Text = numOnRecursionTrack.Value.ToString();
                return;
            }
            widthOfLineTrack.Maximum = this.Width / 2 - 20;
            paintPanel.Width = this.Width / 2;
            valueOfWidthTrack.Text = widthOfLineTrack.Value.ToString();
            valueOfRecursion.Text = numOnRecursionTrack.Value.ToString();


            cochCurve = new CochCurve(widthOfLineTrack.Value, numOnRecursionTrack.Value);
            bitmap = new Bitmap(paintPanel.Width, paintPanel.Height);
            graphics = Graphics.FromImage(bitmap);
            PointF p1 = new PointF(paintPanel.Width / 2 - widthOfLineTrack.Value / 2, paintPanel.Height / 2);
            PointF p2 = new PointF(paintPanel.Width / 2 + widthOfLineTrack.Value / 2, paintPanel.Height / 2);
            PointF p3 = new PointF((p1.X + p2.X) / 2, p1.Y + (float)(widthOfLineTrack.Value * Math.Sqrt(3) / 2));
            IEnumerable<Color> colors = GetGradients(startColor, endColor, numOnRecursionTrack.Value);
            graphics.DrawLine(new Pen(colors.ElementAt<Color>(0)), p1, p2);
            cochCurve.DrawFractal(graphics, paintPanel, p1, p2, p3, widthOfLineTrack.Value, 1, colors);

            paintPanel.BackgroundImage = bitmap;
        }

        private void widthOfLineTrack_ValueChanged(object sender, EventArgs e)
        {
            valueOfWidthTrack.Text = widthOfLineTrack.Value.ToString();
        }

        private void numOnRecursionTrack_ValueChanged(object sender, EventArgs e)
        {
            valueOfRecursion.Text = numOnRecursionTrack.Value.ToString();
        }

        /// <summary>
        /// Рисуем кривую по клику на кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawCurveButton_Click(object sender, EventArgs e)
        {

            bitmap = new Bitmap(paintPanel.Width, paintPanel.Height);
            graphics = Graphics.FromImage(bitmap);

            cochCurve = new CochCurve(widthOfLineTrack.Value, numOnRecursionTrack.Value);

            PointF p1 = new PointF(paintPanel.Width / 2 - widthOfLineTrack.Value / 2, paintPanel.Height/2);
            PointF p2 = new PointF(paintPanel.Width / 2 + widthOfLineTrack.Value / 2, paintPanel.Height/2);
            PointF p3 = new PointF((p1.X+p2.X)/2, p1.Y + (float)(widthOfLineTrack.Value*Math.Sqrt(3)/2));
            IEnumerable<Color> colors = GetGradients(startColor, endColor, numOnRecursionTrack.Value);
            graphics.DrawLine(new Pen(colors.ElementAt<Color>(0)), p1, p2);
            cochCurve.DrawFractal(graphics, paintPanel, p1, p2, p3, widthOfLineTrack.Value, 1, colors);

            paintPanel.BackgroundImage = bitmap;
        }

        /// <summary>
        /// Закрываем эту форму и возвращаемся в главное меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backFromCurve_Click(object sender, EventArgs e)
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
