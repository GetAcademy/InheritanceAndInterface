using System.IO;

namespace InheritanceAndInterface
{
    class FileLineReader : ILineReader
    {
        private readonly StreamReader _streamReader;

        public FileLineReader(string fileName)
        {
            var stream = File.OpenRead(fileName);
            _streamReader = new StreamReader(stream);
        }

        public string GetTheNextLineOrNullIfFinished()
        {
            return _streamReader.ReadLine();
        }
    }
}
