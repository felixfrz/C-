namespace Overload
{
    internal class Program
    {
      
        public void Test()
        {
            Console.WriteLine("1st Method");
        }

    
        public void Test(int i)
        {
            Console.WriteLine("2nd Method");
        }
        public void Test(string s)
        {
            Console.WriteLine("3rd Method");
        }
        public void Test(int i, string s)
        {
            Console.WriteLine("4th Method");
        }
        public void Test(string s, int i)
        {
            Console.WriteLine("5th Method");
        }

        public virtual void TT(string s)
        {
            Console.WriteLine($"Hello {s}");
        }


       
        static void Main(string[] args)
        {

            Program p = new Program();
            p.Test();
            p.Test();
            p.Test(10);
            p.Test("hdhd");
            p.Test(45, "hfhf");
            p.Test("hhd", 78);

            

            string s = "Hello World";
            Console.WriteLine(s.IndexOf("ll"));
            
            Console.ReadLine();
        }
    }
}
