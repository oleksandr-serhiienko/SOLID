using Patterns.SingleRepositoryPrinciple;
using Patterns.SOLID.LiskovSubstitutionPrinciple;
using Patterns.SOLID.OpenClosePrinicple;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Patterns
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //TestSingleRepositoryPrinciple();
        //    //TestOpenClosePrinciple();
        //    //TestLiskovPrinciple();
        //    TestSegregationInterfacePrinciple();
             
        //    Console.Read();
        //}

        private static void TestSegregationInterfacePrinciple()
        {
            throw new NotImplementedException();
        }

        static public int Area(Rectangle r) => r.Width * r.Height;

        private static void TestLiskovPrinciple()
        {
            Rectangle rc = new Rectangle(4,3);
            Console.WriteLine($"{rc} has area {Area(rc)}");

            Rectangle sq = new Square();
            sq.Width = 4;
            Console.WriteLine($"{sq} has area {Area(sq)}");
        }

        public static void TestOpenClosePrinciple ()
        {
            var apple = new Product("Apple", Color.Red, Size.Medium);
            var tree = new Product("Tree", Color.Yellow, Size.Big);
            var house = new Product("House", Color.Blue, Size.Mediocore);

            Product[] products = { apple, tree, house };


            Console.WriteLine("Red Products(old): " );
            foreach (var p in ProductFilter.FilterByColor(products,Color.Red))
            {
                Console.WriteLine($"{p.Name} is {p.Color}");
            }


            BetterFilter bf = new BetterFilter();
            Console.WriteLine("Red Products(new): ");
            foreach (var p in bf.Filter(products, new ColorSpecification(Color.Red)))               
                Console.WriteLine($"{p.Name} is {p.Color}");

            Console.WriteLine("Red Products(new): ");
            foreach (var p in bf.Filter(products, new AndSpecification<Product>(new ColorSpecification(Color.Red), new SizeSpecification(Size.Mediocore))))
                Console.WriteLine($"{p.Name} is {p.Color} and {p.Size}");

        }
        
        public static void TestSingleRepositoryPrinciple()
        {
            var j = new Journal();
            j.AddEntry("newString");
            j.AddEntry("Allesgut");
            Console.WriteLine(j);

            var p = new Persistence();
            var filename = @"‪Temp.txt";
            p.SaveToFile(j, filename, true);
            Process.Start(@"cmd.exe ", filename);
        }
    }
}
