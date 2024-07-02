

namespace MethodHidding
{
    internal class ParentClass
    {
        public virtual void Test1()
        {
            Console.WriteLine("Method Test1 from parent class");
        }

        public void Test2()
        {
            Console.WriteLine("Method Test2 from parent class");
        }

    }

    class ChildClass : ParentClass
    {
        public override void Test1() //MEthod Overriding
        {
            Console.WriteLine("Method Test1 from child class");
        }

        public new void Test2()//Method Hidding/Shadowing
        {
            Console.WriteLine("Method Test2 from child class");
        }

        public void PTest()
        {
            base.Test1();
        }


        public void PTest2()
        {
            base.Test2();
        }


        static void Main(string[] args)
        {


            ChildClass c = new ChildClass();

            c.Test1();
            c.Test2();
            c.PTest();
            c.PTest2();

           
            Console.ReadLine();
        }
    }
}
