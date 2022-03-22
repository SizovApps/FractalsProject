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
    class TriangleFractal : BaseFractal
    {
        public TriangleFractal(int lenOfLine, int maxDepthRecursion) : base(lenOfLine, maxDepthRecursion)
        {
            
        }

        /// <summary>
        /// Рекурсивно рисуем треугольники.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="paintPanel"></param>
        /// <param name="topPoint">Верхняя точка</param>
        /// <param name="leftPoint">Левая точка</param>
        /// <param name="rightPoint">Правая точка</param>
        /// <param name="curNumOfRecursion">текущий номер рекурсии</param>
        /// <param name="colors">Градиент</param>
        public override void DrawFractal(Graphics g, Panel paintPanel, PointF topPoint, PointF leftPoint, PointF rightPoint, int curNumOfRecursion, IEnumerable<Color> colors)
        {
            if (curNumOfRecursion > this.maxDepthRecursion)
            {
                PointF[] points = { topPoint, leftPoint, rightPoint };
                g.DrawPolygon(new Pen(colors.ElementAt<Color>(curNumOfRecursion-2)), points);
            }
            else
            {
                // Находим новый точки.
                PointF leftMid = new PointF(
                    (topPoint.X + leftPoint.X) / 2f,
                    (topPoint.Y + leftPoint.Y) / 2f);
                PointF rightMid = new PointF(
                   (topPoint.X + rightPoint.X) / 2f,
                   (topPoint.Y + rightPoint.Y) / 2f);
                PointF bottomMid = new PointF(
                   (leftPoint.X + rightPoint.X) / 2f,
                   (leftPoint.Y + rightPoint.Y) / 2f);

                // Рисуем новые треугольники.

                DrawFractal(g, paintPanel, topPoint, leftMid, rightMid, curNumOfRecursion + 1, colors);
                DrawFractal(g, paintPanel, leftMid, leftPoint, bottomMid, curNumOfRecursion + 1, colors);
                DrawFractal(g, paintPanel, rightMid, bottomMid, rightPoint, curNumOfRecursion + 1, colors);
            }
        }
    }
}
