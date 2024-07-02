
namespace PropertiesProject
{
    internal class Circle
    {
        private double? _Radius = 10;
        private double _Angle;

      public  enum Colors
        {
            RED,
            GREEN,
            BLUE,
            YELLOW
        }

        public double? Radius
        {
            get { return _Radius; }
            

        }

        public double Angle
        {
            get { return _Angle; }
            set { _Angle = value; }
        }
    }

    class Tes
    {
        static void Main()
        {
            Circle del = new Circle();

            del.Angle = 12.78;

            Console.WriteLine(del.Angle);
            Console.WriteLine(del.Radius);
            Circle.Colors colors = Circle.Colors.GREEN;

            Console.WriteLine(colors);

            Console.ReadLine();
        }
    }
}
