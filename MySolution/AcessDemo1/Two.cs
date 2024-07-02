

namespace AcessDemo1
{
    internal class Two : Program
    {
        static void Main()
        {
            Two t = new Two();


            t.Test2_Internal();
            t.Test3_Protected();
            t.Test4_ProtecedInternal();
            t.Test5_Public();
            t.Test6_PrivateProtected();
            

            Console.ReadLine();

        }
    }
}
