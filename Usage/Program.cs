using System;
using ExternalLibrary;
using Figures;

namespace Usage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure figure1 = new Round(5);
            Console.WriteLine(figure1.getArea());
            Figure figure2 = new Triangle(3, 4, 5);
            Console.WriteLine(figure2.getArea());
            Console.WriteLine(figure1.GetType());
            Triangle t = (Triangle)figure2;
            Console.WriteLine(t.isSquare());
            Figure custom = new CustomFigure(2, 5);
            Console.WriteLine(custom.getArea());
            Console.ReadLine();
        }
    }
}
