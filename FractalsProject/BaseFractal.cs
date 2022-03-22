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
    class BaseFractal
    {
        // Начальная длина линии.
        protected int lenOfLine;
        // Максимальная глубина рекурсии.
        protected int maxDepthRecursion;

        /// <summary>
        /// Базовый конструктор.
        /// </summary>
        /// <param name="lenOfLine">Начальная длина линии</param>
        /// <param name="maxDepthRecursion">Максимальная глубина рекурсии</param>
        public BaseFractal(int lenOfLine, int maxDepthRecursion)
        {
            this.lenOfLine = lenOfLine;
            this.maxDepthRecursion = maxDepthRecursion;
        }



        public virtual void DrawFractal(Graphics g, Panel treePaintPanel, int x, int y, double widhtOfLine)
        {
            
        }

        public virtual void DrawFractal(Graphics g, Panel treePaintPanel, int x, int y, double widhtOfLine, int curNumOfRecursion, double angle)
        {

        }
        public virtual void DrawFractal(Graphics g, Panel treePaintPanel, int x, int y, double angle, int len)
        {

        }

        public virtual void DrawFractal(Graphics g, Panel paintPanel, PointF topPoint, PointF leftPoint, PointF rightPoint, int curNumOfRecursion, IEnumerable<Color> colors)
        {

        }

        public virtual void DrawFractal(Graphics g, Panel treePaintPanel, RectangleF carpet, int curNumOfRecursion, IEnumerable<Color> colors)
        {

        }

        public virtual void DrawFractal(Graphics g, Panel treePaintPanel, PointF point1, PointF point2, PointF point3, double widhtOfLine, int curNumOfRecursion, IEnumerable<Color> colors)
        {

        }

        public virtual void DrawFractal(Graphics g, Panel treePaintPanel, int x, int y, double angle, int len, IEnumerable<Color> colors, int curRecursion)
        {

        }

        public virtual void DrawFractal(Graphics g, Panel kantorSetPaintPanel, int x, int y, double widhtOfLine, int curNumOfRecursion, IEnumerable<Color> colors)
        {

        }

    }
}
