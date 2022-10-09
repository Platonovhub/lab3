namespace laboop3.3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(6, 9, "A");
            Point point2 = new Point(7, 9, "B");
            Point point3 = new Point(8, 7, "C");
            Point point4 = new Point(7, 5, "D");
            Point point5 = new Point(6, 5, "E");
            Figure figure = new Figure(point1, point2, point3, point4, point5);
            Console.WriteLine($"Name: {figure.Name}");
            figure.PerimeterCalculator();
        }
    }
}