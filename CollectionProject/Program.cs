using System.Collections;

namespace CollectionProject
{
    internal class Program
    {
        static void Main()
        {
            Stack s = new Stack();
            s.Push(100);
            s.Push(false);
            s.Push('A');
            s.Push(35.56);
            s.Push("Hello");


            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            s.Pop();

            foreach (var item in s)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();


            Queue queue = new Queue();

            queue.Enqueue(100);
            queue.Enqueue(false);
            foreach (var item in queue)
                Console.WriteLine(item);

            queue.Dequeue();

            foreach (var item in queue)
                Console.WriteLine(item);
        }
    }
}
