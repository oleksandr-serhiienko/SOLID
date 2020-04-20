using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.InterfaceSegregation
{
    public interface IMachine
    {
        void Print(Document d);
        void Load(Document d);
        void Send(Document d);
    }

    public interface IScanner
    {
        void Scan(Document d);
    }

    public interface IPrinter
    {
        void Print(Document d);
    }

    public interface IMultiFunctionalDevise : IScanner, IPrinter
    {

    }
}
