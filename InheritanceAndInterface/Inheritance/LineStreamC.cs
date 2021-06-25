using System.Text;

namespace InheritanceAndInterface.Inheritance
{
    class LineStreamC
    {
        private readonly DummyStream _stream;

        public LineStreamC(DummyStream stream)
        {
            _stream = stream;
        }

        public string ReadLine()
        {
            var builder = new StringBuilder();
            // så lenge det er mer data og siste tegn ikke er linjeskift
            while (!LastCharIsLinebreak(builder)
                && _stream.MoveAndReturnHasMore())
            {
                builder.Append(_stream.GetChar());
            }
            return builder.Length==0 ? null : builder.ToString();
        }

        private static bool LastCharIsLinebreak(StringBuilder builder)
        {
            if (builder.Length == 0) return false;
            return builder[builder.Length - 1] == '\n';
        }
    }
}
