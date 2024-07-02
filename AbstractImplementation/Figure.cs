namespace AbstractImplementation
{
    public abstract class Figure
    {
        public double WIdth, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
    }

    public class Rectangle : Figure
    {
        public Rectangle(double Width, double Height)
        {
            this.WIdth = Width;
            this.Height = Height;
        }

        public override double GetArea()
        {
            return WIdth * Height;
        }
    }


    public class Circle : Figure
    {
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }

        public override double GetArea()
        {
            return Pi * Radius * Radius;
        }
    }

    public class Cone : Figure
    {
        public Cone(double Radius, double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Pi * Radius * (Radius + Math.Sqrt(Height * Height + Radius * Radius));
        }
    }
    class TestFigures
    {
        static void Main()
        {
            Rectangle r = new Rectangle(12.67, 56.78);
            Circle c = new Circle(45.67);
            Cone cn = new Cone(34.98, 12.98);


            Console.WriteLine("Area of Rectangle: " + r.GetArea());
            Console.WriteLine("Area of Circle: " + c.GetArea());
            Console.WriteLine("Area of Cone: " + cn.GetArea());

            Console.ReadLine();
        }
    }
}
