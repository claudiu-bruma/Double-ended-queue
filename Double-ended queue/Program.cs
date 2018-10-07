using Double_ended_queue.DoubleEndedQueue;
using System;

namespace Double_ended_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var deqeue = new DeQueue<string>();

            PopulateTestData(deqeue);
            Console.WriteLine("Popping it all in front :");
            while (!deqeue.IsEmpty())
            {
                Console.Write(deqeue.PopFront() + ' ');
            }
            Console.WriteLine();

            PopulateTestData(deqeue);
            Console.WriteLine("Popping it all in back :");
            while (!deqeue.IsEmpty())
            {
                Console.Write(deqeue.PopBack() + ' ');
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        private static void PopulateTestData(DeQueue<string> deqeue)
        {
            deqeue.PushFront("f 1");
            deqeue.PushFront("f 2 ");

            deqeue.PushBack("b 1");
            deqeue.PushBack("b 2");
        }
    }
}
