using System;

namespace oops
{
    class Trapezium
    {
        readonly int Yehaireadonly;
        const int YehaireadonlyConst =69;
        public readonly int ParallelSide_1;
        private int _height;

        //public Trapezium():
        //    this(-5,10,13)
        //{
        //}

        public Trapezium(int p1, int p2, int h)
        {
            Yehaireadonly = 7;
            ParallelSide_1 = GetLengthOrDefault(p1, nameof(ParallelSide_1));
            //width = GetLengthOrDefault(p2, nameof(Width));
            Width = p2;
            _height = GetLengthOrDefault(h, nameof(_height));
        }
        public int GetHeight() => _height;
        
        public void SetHeight(int val)
        {
            if (val > 0)
            {
                _height = val;
            }
        }
        private int GetLengthOrDefault(int num,string name)
        {
            int defaultValueIfNonPositive = 1;
            if (num <= 0)
            {
                Console.WriteLine($"{name} must be grater than 0");
                return defaultValueIfNonPositive;
            }
            return num;
        }
        public int Width { get; private set; }
        //private int _width;
        //public int Width
        //{
        //    get
        //    {
        //        return _width;
        //    }
        //    private set
        //    {
        //        if(value > 0)
        //        _width = value;

        //    }
        //}
    }
    class ShapesMeasurementsCalculator
    {
        public double CalculateTrapeziumArea(Trapezium trapezium) => 0.5 * (trapezium.ParallelSide_1 + trapezium.Width) * trapezium.GetHeight();
        
    }

    class Program
    {
        static void Main(string[] args)
        {
            var trapezium = new Trapezium(19, 11,0);
            trapezium.SetHeight(17);
            //var trapezium = new Trapezium();
            var calculator = new ShapesMeasurementsCalculator();
            Console.WriteLine(trapezium.ParallelSide_1);
            Console.WriteLine(trapezium.Width);
            Console.WriteLine(trapezium.GetHeight());
            Console.WriteLine(calculator.CalculateTrapeziumArea(trapezium));
            DateTime aaj = DateTime.Now;
            Console.WriteLine(aaj.Year);
        }
    }
}
