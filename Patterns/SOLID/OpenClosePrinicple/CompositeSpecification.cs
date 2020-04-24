using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.OpenClosePrinicple
{
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        protected readonly ISpecification<T>[] items;
        public CompositeSpecification(params ISpecification<T>[] items)
        {
            this.items = items;
        }

        public bool IsSatisfied(T t)
        {
            throw new NotImplementedException();
        }
    }
}
