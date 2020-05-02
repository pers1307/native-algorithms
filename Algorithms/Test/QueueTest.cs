using System;
using Algorithms.Struct;

namespace Algorithms.Test
{
    public static class QueueTest
    {
        public static void Go()
        {
            var myQueue = new MyQueue<int>(10);

            for (int i = 100; i < 200; i++)
            {
                myQueue.Enqueue(i);
                
                if (myQueue.IsFull())
                {
                    break;
                }
            }

            while (!myQueue.IsEmpty())
            {
                Console.WriteLine($"Stack item: {myQueue.Dequeue()}");
            }
        }
    }
}