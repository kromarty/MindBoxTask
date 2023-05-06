using Figures;

namespace ExternalLibrary
{
    public class CustomFigure : Figure
    {
        private double a;
        private double b;
        public CustomFigure(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public override double getArea()
        {
            return a * b;
        }
    }
}