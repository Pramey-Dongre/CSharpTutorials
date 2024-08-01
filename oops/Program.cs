using System;

namespace oops
{
    class Trapezium
    {
        public int ParallelSide_1;
        public int ParallelSide_2;
        public int Height;

        public Trapezium(int p1, int p2, int h)
        {
            ParallelSide_1 = p1;
            ParallelSide_2 = p2;
            Height = h;
        }

        public double CalculateArea()
        {
            return 0.5 * (ParallelSide_1 + ParallelSide_2) * Height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var trapezium = new Trapezium(6,9,17);
            Console.WriteLine(trapezium.ParallelSide_1);
            Console.WriteLine(trapezium.ParallelSide_2);
            Console.WriteLine(trapezium.Height);
            Console.WriteLine(trapezium.CalculateArea());
        }
    }
}
