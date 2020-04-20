using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Patterns.SingleRepositoryPrinciple
{
    public class Persistence
    {
        public void SaveToFile(Journal j, string filename, bool owerwrite = false)
        {
            if (owerwrite || !File.Exists(filename))
            {
                var ff = File.Exists(filename);
                File.WriteAllText(filename, j.ToString());
            }
        }
    }
}
