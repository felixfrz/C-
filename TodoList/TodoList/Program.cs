


var rectangle = new Rectangle(5, 10);
Console.WriteLine(rectangle.Width);
Console.WriteLine(rectangle.Height);

Console.WriteLine(rectangle.CalculateCircumference());
Console.WriteLine(rectangle.CalculateArea());




Console.ReadKey();

class Rectangle
{

    public int Width;
    public int Height;

    public Rectangle(int width, int height)
    {
        Width = width;
        Height = height;
    }


   public int CalculateCircumference() => 2 * Width + 2 * Height;
   

   public int CalculateArea() => Width * Height;
}