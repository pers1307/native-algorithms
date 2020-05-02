using System;
using Algorithms.Struct;

namespace Algorithms.Test
{
    public static class StackTest
    {
        public static void Go()
        {
            var myStack = new MyStack<int>(10);

            for (int i = 100; i < 200; i++)
            {
                myStack.Push(i);

                if (myStack.IsTop())
                {
                    break;
                }
            }

            while (!myStack.Empty())
            {
                Console.WriteLine($"Stack item: {myStack.Pop()}");
            }
        }
    }
}