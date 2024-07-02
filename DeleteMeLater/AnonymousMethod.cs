

namespace DeleteMeLater
{

    internal class AnonymousMethod
    {
        //public static string Greetings(string name)
        //{
        //    return $"Hello {name} a very good morning!";
        //}

        
        public static void AddDelegate(int a, int b)
        {
            Console.WriteLine("The addition of 2 no's is " + (a + b));
        }

        static void Main(string[] args)
        {
            GreetingDelegate gd = delegate (string name)
            {
                return $"Hello {name} a very good morning!";
            };


            Hello greet = delegate (string name)
            {
                Console.WriteLine("Hello " + name);
            };
            string str = gd.Invoke("Felix");

            Console.WriteLine(str);

            Console.WriteLine(gd("Ayodeji"));

            greet("Felix");





            MulDelegate mul = delegate (int a, int b, int c)
            {
                Console.WriteLine("The Multiplication of 3 no's is " + a * b * c);
            };

            mul(2, 5, 8);
            mul(3, 4, 12);

            MulDelegate mul2 = (a, b, c) => Console.WriteLine("The Multiplication of 3 no's is " + a * b * c);



            mul2(2, 5, 8);


            AddDele ad = AddDelegate;


            ad(3, 5);

            Console.ReadLine();
        }
    }
}
