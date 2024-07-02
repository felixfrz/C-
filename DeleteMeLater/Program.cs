

namespace DeleteMeLater
{

    public delegate void Numb(int a, int b);

    internal class Program
    {

        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Main(string[] args)
        {
            Program p = new Program();

            Numb numb = p.Add;
            Numb numb1 = Sub;


            numb(178, 223);
            numb1(34, 7);





            Console.ReadLine();
        }
    }

}
