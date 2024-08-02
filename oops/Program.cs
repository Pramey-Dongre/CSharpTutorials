using System;

namespace oops
{
    class Trapezium
    {
        public int ParallelSide_1;
        public int ParallelSide_2;
        public int Height;

        public Trapezium():
            this(-5,10,13)
        {
        }

        public Trapezium(int p1, int p2, int h)
        {
            ParallelSide_1 = p1;
            ParallelSide_2 = p2;
            Height = h;
        }

    }
    class ShapesMeasurementsCalculator
    {
        public double CalculateTrapeziumArea(Trapezium trapezium) => 0.5 * (trapezium.ParallelSide_1 + trapezium.ParallelSide_2) * trapezium.Height;
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var trapezium = new Trapezium(19, 11, 17);
            var trapezium = new Trapezium();
            var calculator = new ShapesMeasurementsCalculator();
            Console.WriteLine(trapezium.ParallelSide_1);
            Console.WriteLine(trapezium.ParallelSide_2);
            Console.WriteLine(trapezium.Height);
            Console.WriteLine(calculator.CalculateTrapeziumArea(trapezium));
        }
    }
}
