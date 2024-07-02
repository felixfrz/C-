using AbstractImplementation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AbstractImplementationn
{
    internal abstract class Shape
    {

        public double Width, Height;
        public const double Pi = 1.42f;
        public abstract double GetArea();
    }

    internal class Rectangle:Shape
    {
        public Rectangle(double Width, double Height)
        {
            base.Width = Width;
            base.Height = Height;
           
        }

        public override double GetArea() 
        {
            return Width * Height;
        }
    }

    internal class Circle:Shape
    {
        public Circle(double Width)
        {
            base.Width=Width;
        }

        public override double GetArea()
        {
            return Pi * Width;
        }
    }


    internal class Run()
    {
        static void Main()
        {
            Rectangle r = new Rectangle(12.21, 9.22);
            Circle c = new Circle(3.24);

              

            Console.WriteLine(r.GetArea());
            Console.WriteLine(c.GetArea());

            Console.ReadLine();

                    //Friday 26 April 2024

                    //15:35 Item Received
                    //      South Midlands MC
                    //00:39 Item Received
                    //      Princess Royal Parcel Hub

                    //Saturday 20 April 2024
                    //12:03 Sender has despatched item
        }
    }
}
