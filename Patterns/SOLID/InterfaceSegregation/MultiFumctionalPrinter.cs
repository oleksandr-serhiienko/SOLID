using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.SOLID.InterfaceSegregation
{
    public class MultiFumctionalPrinter : IMachine
    {
        public void Print(Document d)
        {
            //
        }

        public void Load(Document d)
        {
            //
        }

        public void Send(Document d)
        {
            //
        }
    }

    public class MultiFunctionalMachine: IMultiFunctionalDevise
    {
        private IPrinter printer;
        private IScanner scanner;

        public MultiFunctionalMachine(IPrinter printer, IScanner scanner)
        {
            this.printer = printer;
            this.scanner = scanner;
        }


        public void Print(Document d)
        {
            printer.Print(d);
        }

        public void Scan(Document d)
        {
            scanner.Scan(d);
        }
    }

    public  class OldFasionPrinter : IMachine
    {
        public void Print(Document d)
        {
             
        }

        public void Load(Document d)
        {
            throw new NotImplementedException();
        }

        public void Send(Document d)
        {
            throw new NotImplementedException();
        }
    }
}
