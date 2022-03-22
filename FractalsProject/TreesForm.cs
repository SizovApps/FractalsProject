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
    public partial class TreesForm : Form
    {

        Graphics graphics;
        TreeFractal treeFractal;
        // Переданы ли все необходимые параметры корректно.
        bool parametrsReady;

        // Сюда записываем наш рисунок.
        Bitmap bitmap;

        // Начальный и конечный цвет градиента.
        Color startColor;
        Color endColor;

        /// <summary>
        /// Конструктор формы.
        /// </summary>
        public TreesForm()
        {
            InitializeComponent();
            parametrsReady = false;
            startColor = Color.Black;
            endColor = Color.Black;
        }

        /// <summary>
        /// Рисуем дерево по клику на кнопку.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeConfirm_Click(object sender, EventArgs e)
        {
            // Есть ли ошибки в данных.
            bool findMistakes = false;
            if (!double.TryParse(treeCoefInput.Text, out double treeCoef) || treeCoef < 0.1 || treeCoef > 0.9)
            {
                findMistakes = true;
            }
            if (!double.TryParse(firstTreeAngleInput.Text, out double firstAngle) || firstAngle < -360 || firstAngle > 360)
            {
                findMistakes = true;
            }
            if (!double.TryParse(secondTreeAngleInput.Text, out double secondAngle) || secondAngle < -360 || secondAngle > 360)
            {
                findMistakes = true;
            }
            if (!int.TryParse(treeLenInput.Text, out int treeLen) || treeLen < 10 || treeLen > this.ClientSize.Height / 2 || treeLen > this.ClientSize.Width / 2)
            {
                findMistakes = true;
            }
            if (!int.TryParse(treeRecursionLenInput.Text, out int treeRecursionLen) || treeRecursionLen < 1 || treeRecursionLen > 15)
            {
                findMistakes = true;
            }
            if (findMistakes == false)
            {
                // Создаем новый bitmap и присваеваем ему текуший рисунок.
                bitmap = new Bitmap(treePaintPanel.Width, treePaintPanel.Height);
                graphics = Graphics.FromImage(bitmap); 

                // Создаем экземпляр дерева.
                parametrsReady = true;
                treeFractal = new TreeFractal(treeLen, treeRecursionLen, treeCoef, firstAngle, secondAngle);
                treePaintPanel.Width = this.Width / 2;
         
                // Получаем цвета градиента.
                IEnumerable<Color> colors = GetGradients(startColor, endColor, treeRecursionLen);
                treeFractal.DrawFractal(graphics, treePaintPanel, treePaintPanel.Width / 2, 0, 0, treeLen, colors, 1);

                treePaintPanel.BackgroundImage = bitmap;
            }
            else
            {
                MessageBox.Show("Некорректные данные попробуйте еще раз!");
            }
        }

        /// <summary>
        /// Закрываем эту форму и возвращаемся в главное меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void backFromTree_Click(object sender, EventArgs e)
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
        /// Обновляем рисунок и параметры при изменении размеров экрана.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TreesForm_Resize(object sender, EventArgs e)
        {
            if (bitmap == null)
            {
                treePaintPanel.Width = this.Width / 2;
                return;
            }
            treePaintPanel.Width = this.Width / 2;
            if (parametrsReady)
            {
                bool findMistakes = false;
                if (!double.TryParse(treeCoefInput.Text, out double treeCoef) || treeCoef < 0.1 || treeCoef > 0.9)
                {
                    findMistakes = true;
                }
                if (!double.TryParse(firstTreeAngleInput.Text, out double firstAngle) || firstAngle < -360 || firstAngle > 360)
                {
                    findMistakes = true;
                }
                if (!double.TryParse(secondTreeAngleInput.Text, out double secondAngle) || secondAngle < -360 || secondAngle > 360)
                {
                    findMistakes = true;
                }
                if (!int.TryParse(treeLenInput.Text, out int treeLen) || treeLen < 10 || treeLen > this.ClientSize.Height / 2 || treeLen > this.ClientSize.Width / 2)
                {
                    findMistakes = true;
                }
                if (!int.TryParse(treeRecursionLenInput.Text, out int treeRecursionLen) || treeRecursionLen < 1 || treeRecursionLen > 15)
                {
                    findMistakes = true;
                }
                if (findMistakes == false)
                {
                    parametrsReady = true;
                    treeFractal = new TreeFractal(treeLen, treeRecursionLen, treeCoef, firstAngle, secondAngle);
                    treePaintPanel.Width = this.Width / 2;

                    bitmap = new Bitmap(treePaintPanel.Width, treePaintPanel.Height);
                    graphics = Graphics.FromImage(bitmap);

                    IEnumerable<Color> colors = GetGradients(startColor, endColor, treeRecursionLen);
                    treeFractal.DrawFractal(graphics, treePaintPanel, treePaintPanel.Width / 2, 0, 0, treeLen, colors, 1);
                    treePaintPanel.BackgroundImage = bitmap;
                }
                else
                {
                    MessageBox.Show("Некорректные данные попробуйте еще раз!");
                }
            }
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
