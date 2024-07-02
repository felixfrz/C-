using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Class9
    {
        static void Main()
        {
            string[] colors = { "Red", "Blue", "Green", "Black", "White", "Brown", "Orange", "Purple", "Yellow", "Aqua" };

            var arr = from i in colors select i;
            Console.WriteLine(String.Join(", ", arr) + "\n");

            var brr = from i in colors orderby i select i;
            Console.WriteLine(String.Join(", ", brr) + "\n");

            var crr = from i in colors orderby i descending select i;
            Console.WriteLine(String.Join(", ", crr) + "\n");

            var drr = from i in colors where i.Length == 5 select i;
            Console.WriteLine(String.Join(", ", drr)+"\n");

            var err = from i in colors where i[0] == 'B' select i;
            Console.WriteLine(String.Join(", ", err) + "\n");

            var coll6 = from s in colors where s.IndexOf("B") == 0 select s;
            Console.WriteLine(String.Join(" ", coll6));
            var coll7 = from s in colors where s.StartsWith("B") select s;
            Console.WriteLine(String.Join(" ", coll7));
            var coll8 = from s in colors where s.Substring(0, 1) == "B" select s;
            Console.WriteLine(String.Join(" ", coll8) + "\n");

            //Getting the list of colors whose name ends with character "e":
            var coll9 = from s in colors where s[s.Length - 1] == 'e' select s;
            Console.WriteLine(String.Join(" ", coll9));
            var coll10 = from s in colors where s.IndexOf("e") == s.Length - 1 select s;
            Console.WriteLine(String.Join(" ", coll10));
            var coll11 = from s in colors where s.EndsWith("e") select s;
            Console.WriteLine(String.Join(" ", coll11));
            var coll12 = from s in colors where s.Substring(s.Length - 1) == "e" select s;
            Console.WriteLine(String.Join(" ", coll12) + "\n");

            //Getting the list of colors whose name contains character "a" at 3rd place: 
            var coll13 = from s in colors where s[2] == 'a' select s;
            Console.WriteLine(String.Join(" ", coll13));
            var coll14 = from s in colors where s.IndexOf("a") == 2 select s;
            Console.WriteLine(String.Join(" ", coll14));
            var coll15 = from s in colors where s.Substring(2, 1) == "a" select s;
            Console.WriteLine(String.Join(" ", coll15) + "\n");

            //Getting the list of colors whose name contains character "O or o" in it: 
            var coll16 = from s in colors where s.Contains('O') || s.Contains('o') select s;
            Console.WriteLine(String.Join(" ", coll16));
            var coll17 = from s in colors where s.IndexOf('O') >= 0 || s.IndexOf('o') >= 0 select s;
            Console.WriteLine(String.Join(" ", coll17));
            var coll18 = from s in colors where s.ToUpper().Contains('O') select s;
            Console.WriteLine(String.Join(" ", coll18));
            var coll19 = from s in colors where s.ToLower().IndexOf('o') >= 0 select s;
            Console.WriteLine(String.Join(" ", coll19) + "\n");

            //Getting the list of colors whose name doesn’t contains character "O or o" in it: 
            var coll20 = from s in colors where s.Contains('O') == false && s.Contains('o') == false select s;
            Console.WriteLine(String.Join(" ", coll20));
            var coll21 = from s in colors where s.IndexOf('O') == -1 && s.IndexOf('o') == -1 select s;
            Console.WriteLine(String.Join(" ", coll21));
            var coll22 = from s in colors where s.ToUpper().Contains('O') == false select s;
            Console.WriteLine(String.Join(" ", coll22));
            var coll23 = from s in colors where s.ToLower().IndexOf('o') == -1 select s;
            Console.WriteLine(String.Join(" ", coll23) + "\n");

            Console.ReadLine();
        }
    }
}
