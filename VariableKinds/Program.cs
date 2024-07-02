namespace VariableKinds
{
    internal class Program
    {
        
        int x;  // Non-static
        static int y = 200; //  Static
        const float pi = 3.14f;
        readonly bool flag;
        public Program(int x, bool flag)
        {
            this.x = x;
            
            this.flag = flag;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(y);
            Console.WriteLine(pi);

            Program p = new Program(100, true);
            Console.WriteLine(p.x);
         
          
            Console.ReadLine();
        }
    }
}
