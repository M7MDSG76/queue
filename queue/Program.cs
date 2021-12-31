using System;

namespace queue
{
    class Program
    {
        
        static void Main(string[] args)
        {
            queue x = new queue(5);
            x.PrintQueue();
            x.Peek();
            x.Enqueue(1);
            x.Enqueue(2);
            x.PrintQueue();
            x.Dequeue();
            x.PrintQueue();
            x.Enqueue(4);
            x.Enqueue(5);
            x.Enqueue(5);
            x.PrintQueue();
            x.Peek();




        }
    }
}
