using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FractalsProject
{
    class CochCurve : BaseFractal
    {
        public CochCurve(int lenOfLine, int maxDepthRecursion) : base(lenOfLine, maxDepthRecursion)
        {

        }

        /// <summary>
        /// Рекурсивно рисуем линии.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="treePaintPanel"></param>
        /// <param name="point1">Левая точка</param>
        /// <param name="point2">Правая точка</param>
        /// <param name="point3">Нижняя точка, противоположная новой</param>
        /// <param name="widhtOfLine">Длина линии</param>
        /// <param name="curNumOfRecursion">Текущий номер рекурсии</param>
        /// <param name="colors">Градиент</param>
        public override void DrawFractal(Graphics g, Panel treePaintPanel, PointF point1, PointF point2, PointF point3, double widhtOfLine, int curNumOfRecursion, IEnumerable<Color> colors)
        {
            if (widhtOfLine < 3 || curNumOfRecursion > maxDepthRecursion)
            {
                return;
            }

            var point4 = new PointF((point2.X + 2 * point1.X) / 3, (point2.Y + 2 * point1.Y) / 3);
            var point5 = new PointF((2 * point2.X + point1.X) / 3, (point1.Y + 2 * point2.Y) / 3);

            var pointS = new PointF((point2.X + point1.X) / 2, (point2.Y + point1.Y) / 2);
            var pointN = new PointF((4 * pointS.X - point3.X) / 3, (4 * pointS.Y - point3.Y) / 3);

            g.DrawLine(new Pen(colors.ElementAt<Color>(curNumOfRecursion-1)), point4, pointN);
            g.DrawLine(new Pen(colors.ElementAt<Color>(curNumOfRecursion - 1)), point5, pointN);

            DrawFractal(g, treePaintPanel, point4, pointN, point5, widhtOfLine / 3, curNumOfRecursion + 1, colors);
            DrawFractal(g, treePaintPanel, pointN, point5, point4, widhtOfLine / 3, curNumOfRecursion + 1, colors);
            DrawFractal(g, treePaintPanel, point1, point4, new PointF((2 * point1.X + point3.X) / 3, (2 * point1.Y + point3.Y) / 3), widhtOfLine / 3, curNumOfRecursion + 1, colors);
            DrawFractal(g, treePaintPanel, point5, point2, new PointF((2 * point2.X + point3.X) / 3, (2 * point2.Y + point3.Y) / 3), widhtOfLine / 3, curNumOfRecursion + 1, colors);


        }
    }   
}
