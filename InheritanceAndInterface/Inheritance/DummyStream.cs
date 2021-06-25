namespace InheritanceAndInterface
{
    class DummyStream
    {
        private int _index = -1;
        private string _dummyData = @"
3,4
80,5
10,3
-30,-30
";

        public char GetChar()
        {
            return _dummyData[_index];
        }

        public bool MoveAndReturnHasMore()
        {
            _index++;
            return _index < _dummyData.Length;
        }
    }
}
