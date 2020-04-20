using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.SOLID.OpenClosePrinicple
{
    public class Product
    {
        public string Name;
        public Color Color;
        public Size Size;

        public Product(string name, Color color, Size size)
        {
            if (name == null)
                throw new ArgumentNullException(paramName: nameof(name));
            
            Name = name;
            Color = color;
            Size = size;
        }
    }

    public enum Color
    {
        Red, Blue, Yellow
    }

    public enum Size
    {
        Small, Big, Medium, Mediocore
    }
}
