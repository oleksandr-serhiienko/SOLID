using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Patterns.SingleRepositoryPrinciple
{
    public class Journal
    {
        private readonly List<string> entries = new List<string>();
        private static int count = 0;
        public int AddEntry(string text)
        {
            entries.Add($"{++count}: {text}");
            return count;
        }

        public void RemoveEntry(int index)
        {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }

        //public void Save(string fileName)
        //{
        //    File.WriteAllText(fileName, ToString());
        //}

        //public static Journal Load(string fileName)
        //{
        //    return new Journal();
        //}

        //public void Load(Uri uri)
        //{ 
        //}

    }
}
