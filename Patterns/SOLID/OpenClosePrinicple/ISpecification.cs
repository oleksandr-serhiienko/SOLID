using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.OpenClosePrinicple
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
