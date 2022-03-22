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
    class TreeFractal : BaseFractal
    {
        // Коэф. уменьшения длины дерева и углы под которыми расходятся ветви.
        double treeCoef;
        double firstAngle;
        double secondAngle;

        /// <summary>
        /// Конструктор дерева.
        /// </summary>
        /// <param name="lenOfLine">Начальная длина ветви.</param>
        /// <param name="maxDepthRecursion">Максимальная глубина рекурсии.</param>
        /// <param name="treeCoef"> Коэф. уменьшения длины дерева</param>
        /// <param name="firstAngle">Первый угол</param>
        /// <param name="secondAngle">Второй угол</param>
        public TreeFractal(int lenOfLine, int maxDepthRecursion, double treeCoef, double firstAngle, double secondAngle) : base(lenOfLine, maxDepthRecursion)
        {
            this.treeCoef = treeCoef;
            this.firstAngle = firstAngle;
            this.secondAngle = secondAngle;
        }

        /// <summary>
        /// Рекурсивно рисуем дерево.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="treePaintPanel"></param>
        /// <param name="x">Начальная координата</param>
        /// <param name="y">Начальная координата</param>
        /// <param name="angle">Текущий угол</param>
        /// <param name="len">Текушая длина</param>
        /// <param name="colors">Цвета градиента</param>
        /// <param name="curRecursion">Текущий номер рекурсии</param>
        public override void DrawFractal(Graphics g, Panel treePaintPanel, int x, int y, double angle, int len, IEnumerable<Color> colors, int curRecursion)
        {
            if (IsFractalDeapthReached(len))
            {
                return;
            }
            double x1, y1;
            x1 = x + len * Math.Sin(angle * Math.PI * 2 / 360.0);
            y1 = y + len * Math.Cos(angle * Math.PI * 2 / 360.0);
            g.DrawLine(new Pen(colors.ElementAt<Color>(curRecursion-1)), x, treePaintPanel.Height-y, (int)x1, treePaintPanel.Height - (int)y1);
            DrawFractal(g, treePaintPanel, (int)x1, (int)y1, angle + firstAngle, (int)(len * treeCoef), colors, curRecursion+1);
            DrawFractal(g, treePaintPanel, (int)x1, (int)y1, angle + secondAngle, (int)(len * treeCoef), colors, curRecursion+1);
        }

        /// <summary>
        /// Достигнута ли максимальная глубина.
        /// </summary>
        /// <param name="len">Текущая длина.</param>
        /// <returns></returns>
        private bool IsFractalDeapthReached(double len)
        {
            return len < lenOfLine * Math.Pow(treeCoef, maxDepthRecursion);
        }
    }
}
