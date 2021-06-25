using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndInterface.Inheritance
{
    class LineStreamI : DummyStream
    {
        public string ReadLine()
        {
            var builder = new StringBuilder();
            // så lenge det er mer data og siste tegn ikke er linjeskift
            while (!LastCharIsLinebreak(builder)
                   && MoveAndReturnHasMore())
            {
                builder.Append(GetChar());
            }
            return builder.Length == 0 ? null : builder.ToString();
        }

        private static bool LastCharIsLinebreak(StringBuilder builder)
        {
            if (builder.Length == 0) return false;
            return builder[builder.Length - 1] == '\n';
        }
    }
}
