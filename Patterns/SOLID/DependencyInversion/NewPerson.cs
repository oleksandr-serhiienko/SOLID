using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;
using System.Xml.XPath;

namespace Patterns.SOLID.DependencyInversion
{
    public class Person
    {
        public string Name;
    }

    public enum Relationship
    {
        Parent,
        Child,
        Sibling
    }

    public class Relationships : IRealatinships
    {
        private List<(Person, Relationship, Person)> relationships 
            = new List<(Person, Relationship, Person)>();

        public void AddParentAndChild(Person parent, Person child)
        {
            relationships.Add((parent, Relationship.Parent, child));
            relationships.Add((child, Relationship.Child, parent));
        }

        public IEnumerable<Person> FindAllChildrenOf(string name)
        {
            foreach (var r in relationships.Where(x => x.Item1.Name == name && x.Item2 == Relationship.Parent))
            {
                yield return r.Item3;
            }
            
        }
    }

    public interface IRealatinships
    {
        IEnumerable<Person> FindAllChildrenOf(string name);
    }

    public class Research
    {

        public Research(IRealatinships browser)
        {
            foreach (var p in browser.FindAllChildrenOf("Jeremy"))
            {
                Console.WriteLine(p.Name);
            }
        }

        static void Main(string[] args)
        {

            var parent = new Person {Name = "Jeremy"};
            var child1 = new Person { Name = "Sasha" };
            var child2 = new Person { Name = "Boris" };

            var relationships = new Relationships();
            relationships.AddParentAndChild(parent, child1);
            relationships.AddParentAndChild(parent, child2);


            var dd = new Research(relationships);
        }

    }

}
