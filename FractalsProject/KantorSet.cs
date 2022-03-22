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
    class KantorSet : BaseFractal
    {
        // Отступ снизу между линиями.
        double spaceBetweenLines;

        public KantorSet(int lenOfLine, int maxDepthRecursion, double spaceBetweenLines, int maxNumOfRecusion) : base(lenOfLine, maxDepthRecursion)
        {
            this.spaceBetweenLines = spaceBetweenLines;
        }

        /// <summary>
        /// Рекурсивно рисуем линии.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="kantorSetPaintPanel"></param>
        /// <param name="x">Стартовая позиция</param>
        /// <param name="y">Стартовая позиция</param>
        /// <param name="widhtOfLine">Длина линии</param>
        /// <param name="curNumOfRecursion">Текущий номер рекурсии</param>
        /// <param name="colors">Градиент</param>
        public override void DrawFractal(Graphics g, Panel kantorSetPaintPanel, int x, int y, double widhtOfLine, int curNumOfRecursion, IEnumerable<Color> colors)
        {
            if (widhtOfLine < 3 || curNumOfRecursion > this.maxDepthRecursion)
            {
                return;
            }

            g.FillRectangle(new SolidBrush(colors.ElementAt<Color>(curNumOfRecursion-1)), new Rectangle(x, y, (int)widhtOfLine, 5));
            DrawFractal(g, kantorSetPaintPanel, x, (int)(y + spaceBetweenLines + 5), widhtOfLine / 3, curNumOfRecursion + 1, colors);
            DrawFractal(g, kantorSetPaintPanel, (int)(x + 2 * widhtOfLine / 3), (int)(y + spaceBetweenLines + 5), widhtOfLine / 3, curNumOfRecursion + 1, colors);
        }

    }
}
