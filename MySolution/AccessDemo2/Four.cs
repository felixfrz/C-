namespace AccessDemo2
{
    internal class Four : AcessDemo1.Program
    {
        static void Main(string[] args)
        {

            Four f = new Four();
            f.Test3_Protected();
            f.Test4_ProtecedInternal();
            f.Test5_Public();

            Console.ReadLine();
        }
    }
}
