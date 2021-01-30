using System;

namespace ConsoleApp76
{



    class rectangle
    {
        public double side1 { get; set; }
        public double side2 { get; set; }


        public rectangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public double AreaCalcilator()
        {
            return side1 * side2;
        }
        public double perimetercalculator()
        {
            return 2 * (side1 + side2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine());
            rectangle rectangle = new rectangle(a, b);
            double area = rectangle.AreaCalcilator();
            double perimeter = rectangle.perimetercalculator();
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
            Console.ReadKey();

        }
    }
}   
