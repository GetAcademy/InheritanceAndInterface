using System;

namespace InheritanceAndInterface
{
    class NumberLinesSumCalculator
    {
        private readonly ILineReader _lineReader;

        public NumberLinesSumCalculator(ILineReader lineReader)
        {
            _lineReader = lineReader;
        }

        public int GetSum()
        {

            var sum = 0;
            var line = _lineReader.GetTheNextLineOrNullIfFinished();
            while (line != null)
            {
                var number = Convert.ToInt32(line);
                sum += number;
                line = _lineReader.GetTheNextLineOrNullIfFinished();
            }
            return sum;
        }
    }
}
