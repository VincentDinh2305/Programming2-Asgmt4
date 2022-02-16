using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace Assignment04
{
    class DrawableEllipse : Primitive, IDrawable
    {
        int DEVIDE_BY_TWO = 2;

        public DrawableEllipse(Color color, bool filled,
        Rectangle rectangle) : base(color, filled, rectangle)
        {
            //this.color = color;
            //this.filled = filled;
            //boundingRectangle = rectangle;
        }

        public void Draw(Graphics g)
        {
            if (filled == true)
            {
                SolidBrush newDraw = new SolidBrush(color);
                g.FillEllipse(newDraw, boundingRectangle);
            }
            else
            {
                Pen newDraw = new Pen(color);
                g.DrawEllipse(newDraw, boundingRectangle);
            }
        }

        public double Area()
        {
            return (boundingRectangle.Width / DEVIDE_BY_TWO)
            * (boundingRectangle.Height / DEVIDE_BY_TWO)
            * Math.PI;
        }
    }
}