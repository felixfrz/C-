using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class HashCollection
    {






        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("Eid", 100);
            ht.Add("Ename", "Frz");

            foreach (object key in ht.Keys) 
                Console.WriteLine(key.GetHashCode());


            Console.ReadLine();



        }
    }
}
