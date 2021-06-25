using System;
using System.IO;

namespace InheritanceAndInterface
{
    class NumberFileSumCalculator
    {
        public static int GetSum()
        {
            var stream = File.OpenRead("Numbers.txt");
            var reader = new StreamReader(stream);
            var sum = 0;
            var line = reader.ReadLine();
            while (line != null)
            {
                var number = Convert.ToInt32(line);
                sum += number;
                line = reader.ReadLine();
            }
            return sum;
        }
    }
}
