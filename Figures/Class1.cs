using System;
using System.Collections.Generic;

namespace Figures
{
    public class Figure
    {
        public virtual double getArea()
        {
            return 0;
        }
    }

    public class Round : Figure
    {
        private double r;

        public Round(double r)
        {
            this.r = r;
        }

        public override double getArea()
        {
            return 3.14 * r * r;
        }
    }

    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            List<double> r = new List<double>
            {
                a,
                b,
                c
            };
            r.Sort();
            this.a = r[0];
            this.b = r[1];
            this.c = r[2];
        }

        public override double getArea()
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        public bool isSquare()
        {
            return c * c == a * a + b * b;
        }
    }
}
