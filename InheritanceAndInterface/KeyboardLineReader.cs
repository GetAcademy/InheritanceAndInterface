using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterface
{
    class KeyboardLineReader:ILineReader
    {
        public string GetTheNextLineOrNullIfFinished()
        {
            Console.Write("Skriv et tall eller blank for å avslutte: ");
            var line = Console.ReadLine();
            return string.IsNullOrWhiteSpace(line) ? null : line;
        }
    }
}
