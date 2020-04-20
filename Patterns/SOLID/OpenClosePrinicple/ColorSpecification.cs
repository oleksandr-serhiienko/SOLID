﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.OpenClosePrinicple
{
    public class ColorSpecification : ISpecification<Product>
    {
        private Color color;

        public ColorSpecification( Color color)
        {
            this.color = color;
        }

        public bool IsSatisfied(Product t)
        {
            return t.Color == color;
        }
    }
}
