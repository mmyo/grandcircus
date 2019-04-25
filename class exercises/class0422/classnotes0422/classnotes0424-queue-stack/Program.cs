using System;
using System.Collections.Generic;

namespace classnotes0424_queue_stack
{
    class Program
    {
        static void Main(string[] args)
        {

            //Queue FIFO

            var queue = new Queue<string>();

            queue.Enqueue("hello");
            queue.Enqueue("world");
                
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            //Stack LIFO
            var stack = new Stack<string>();
            stack.Push("hello");
            stack.Push("world");

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            Console.ReadLine();
        }
    }
}
