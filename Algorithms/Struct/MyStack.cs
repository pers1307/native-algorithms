using System;

namespace Algorithms.Struct
{
    public class MyStack<Type>
    {
        private int top = 0;
        private int lenght = 0;
        private Type[] array;

        public MyStack(int lenght)
        {
            array = new Type[lenght];
            this.lenght = lenght;
        }

        public void Push(Type item)
        {
            if (top > lenght - 1)
            {
                throw new Exception("Переполнение стека");
            }
            
            array[top++] = item;
        }

        public Type Pop()
        {
            if (top < 0)
            {
                throw new Exception("Стек пуст");
            }
            
            return array[top--];
        }

        public bool Empty()
        {
            return top == 0;
        }

        public bool IsTop()
        {
            return top == lenght - 1;
        }
    }
}