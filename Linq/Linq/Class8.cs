using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Class8
    {
        static void Main()
        {
            List<int> coll1 = new List<int>() { 13, 56, 29, 98, 24, 54, 79, 39, 8, 42, 22, 93, 6, 73, 35, 67, 48, 18, 61, 32, 86, 15, 21, 81, 2 };
            var coll2 = from i in coll1 where i > 40 orderby i descending select i;
         
            Console.WriteLine(String.Join(", ", coll2));

            int[] arr = { 13, 56, 29, 98, 24, 54, 79, 39, 8, 42, 22, 93, 6, 73, 35, 67, 48, 18, 61, 32, 86, 15, 21, 81, 2 };
            var brr = from i in arr where i > 40 orderby i descending select i;
            Console.WriteLine(String.Join(", ", brr));


            Console.ReadLine();
        }
    }
}
