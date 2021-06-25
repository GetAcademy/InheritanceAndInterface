using System;

namespace InheritanceAndInterface
{
    class NumberLinesSumCalculator2
    {
        public int Sum { get; private set; }

        public void AddNumberLine(string line)
        {
            var number = Convert.ToInt32(line);
            Sum += number;
        }
    }
}
