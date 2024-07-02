
using AccessDemo4;

namespace AccessDemo2
{
    internal class TestVB
    {
        static void Main()
        {
            Class1 obj = new Class1();
            obj.AddNum(10, 5);
            Console.WriteLine(obj.SayHello("Felix"));

            Console.ReadLine();
        }
    }
}
