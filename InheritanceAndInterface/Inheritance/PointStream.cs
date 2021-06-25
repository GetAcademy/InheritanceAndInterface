namespace InheritanceAndInterface.Inheritance
{
    class PointStream : LineStreamI
    {
        public Point ReadPoint()
        {
            var line = ReadLine();
            if (string.IsNullOrWhiteSpace(line)) return null;
            var values = line.Split(',');
            return new Point(values[0], values[1]);
        }
    }
}
