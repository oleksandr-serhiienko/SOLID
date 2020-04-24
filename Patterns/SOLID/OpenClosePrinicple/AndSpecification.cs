using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Patterns.SOLID.OpenClosePrinicple
{
    public class AndSpecification<T> : CompositeSpecification<T>
    {
        public AndSpecification(params ISpecification<T>[] items) : base(items)
        {
        }

        public bool IsSatisfied(T t)
        {
            return items.All(i => i.IsSatisfied(t));
        }
    }
}
