using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.LiskovSubstitutionPrinciple
{
    public class Rectangle
    {
        public virtual int Width { get; set; }

        public virtual int Height { get; set; }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle()
        {

        }

        public override string ToString()
        {
            return $"{nameof(Width)}: {Width}, {nameof(Height)} : {Height}";
        }
    }
}
