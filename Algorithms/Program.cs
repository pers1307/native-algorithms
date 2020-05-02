using System;
using Algorithms.Test;

namespace Algorithms
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Stack Test:");
            Console.WriteLine("**********************************");
            StackTest.Go();
            Console.WriteLine("Queue Test:");
            Console.WriteLine("**********************************");
            QueueTest.Go();
            
            
            Console.ReadKey();
        }
    }
}