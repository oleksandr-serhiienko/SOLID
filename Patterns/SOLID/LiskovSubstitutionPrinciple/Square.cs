using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.LiskovSubstitutionPrinciple
{
    public class Square : Rectangle
    {
        public Square(int width, int height) : base(width, height)
        {
        }


        public Square()
        {

        }
        public override int Width
        {
            set { base.Width = base.Height = value; }
        }

        public override int Height
        {
            set { base.Height = base.Width = value; }
        }
    }
}
