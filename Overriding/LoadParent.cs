using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    internal class LoadParent
    {
        public void Show()
        {
            Console.WriteLine("Parent's Show Method is called.");
        }
        public virtual void Test() //Overidable
        {
            Console.WriteLine("Parent's Test Method is Called.");
        }
    
    }

    class LoadChild: LoadParent
    {
        public void Show(int i)
        {
            Console.WriteLine("Child's Show Method is called.");
        }

        public override void Test()
        {
            Console.WriteLine("Child's Test Method is called.");
        }

       
        static void Main(string[] args)
        {
            LoadChild c = new LoadChild();
            c.Show();
            c.Show(10);
            c.Test();


            Console.ReadLine();
        }
    }
}
