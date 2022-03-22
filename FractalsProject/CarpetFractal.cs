using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalsProject
{
    class CarpetFractal : BaseFractal
    {
        // Высота ковра
        int heightOfCarpet;

        public CarpetFractal(int lenOfLine, int heightOfCarpet, int maxDepthRecursion) : base(lenOfLine, maxDepthRecursion)
        {
            this.heightOfCarpet = heightOfCarpet;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="paintPanel"></param>
        /// <param name="carpet">Прямоугольник для разбиения</param>
        /// <param name="curNumOfRecursion">Текущий номер рекурсии</param>
        /// <param name="colors">Градиент</param>
        public override void DrawFractal(Graphics g, Panel paintPanel, RectangleF carpet, int curNumOfRecursion, IEnumerable<Color> colors)
        {
            // Если построение закончилось.
            if (curNumOfRecursion > maxDepthRecursion)
            {
                // Рисуем прямоугольник.
                g.FillRectangle(new SolidBrush(colors.ElementAt<Color>(curNumOfRecursion-2)), carpet);
            }
            else
            {
                // Делим прямоугольник на 9 частей.
                var width = carpet.Width / 3;
                var height = carpet.Height / 3;

                // Вычисляем координаты новых точек.
                var x1 = carpet.Left;
                var x2 = x1 + width;
                var x3 = x1 + 2f * width;

                var y1 = carpet.Top;
                var y2 = y1 + height;
                var y3 = y1 + 2f * height;

                // Запускаем рекурсии по новым прямоугольникам.

                DrawFractal(g, paintPanel, new RectangleF(x1, y1, width, height), curNumOfRecursion + 1, colors);
                DrawFractal(g, paintPanel, new RectangleF(x2, y1, width, height), curNumOfRecursion + 1, colors);
                DrawFractal(g, paintPanel, new RectangleF(x3, y1, width, height), curNumOfRecursion + 1, colors);
                DrawFractal(g, paintPanel, new RectangleF(x1, y2, width, height), curNumOfRecursion + 1, colors);
                DrawFractal(g, paintPanel, new RectangleF(x3, y2, width, height), curNumOfRecursion + 1, colors);
                DrawFractal(g, paintPanel, new RectangleF(x1, y1, width, height), curNumOfRecursion + 1, colors);
                DrawFractal(g, paintPanel, new RectangleF(x1, y3, width, height), curNumOfRecursion + 1, colors);
                DrawFractal(g, paintPanel, new RectangleF(x2, y3, width, height), curNumOfRecursion + 1, colors);
                DrawFractal(g, paintPanel, new RectangleF(x3, y3, width, height), curNumOfRecursion + 1, colors);

            }

        }


    }
}
