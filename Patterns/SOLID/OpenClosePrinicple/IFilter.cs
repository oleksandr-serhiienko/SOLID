using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.OpenClosePrinicple
{
    public interface IFilter<T>
    {
        IEnumerable<T> Filter(IEnumerable<T> items, ISpecification<T> spec);
    }
}
