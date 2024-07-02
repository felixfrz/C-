namespace Construc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CopyConstructor cd1 = new CopyConstructor(1005);
            cd1.Display();
            CopyConstructor cd2 = new CopyConstructor(cd1);
            cd2.Display();

            Console.WriteLine();
            cd1.Balance = 10000;
            cd1.Display();
            cd2.Display();
            Console.WriteLine();
            cd2.Balance = 20000;
            cd1.Display();
            cd2.Display();
            Console.ReadLine();
        }
    }


    class CopyConstructor
    {
        int Id;
        string Name;
        public double Balance;

        public CopyConstructor(int Id)
        {
            this.Id = Id;
            Name = "Frz";
            Balance = 600.0;
        }


        public CopyConstructor(CopyConstructor cd)
        {
            this.Id = cd.Id;
            Name = cd.Name;
            Balance = cd.Balance;
        }


        public void Display()
        {
            Console.WriteLine($" Id: {Id} Name: {Name} Balance : {Balance}");
        }
    }
}
