using System;

namespace Algorithms.Struct
{
    public class MyQueue<Type>
    {
        private int head = 0;
        private int tail = 0;
        private int lenght = 0;
        private Type[] array;
        
        public MyQueue(int lenght)
        {
            array = new Type[lenght];
            this.lenght = lenght;
        }

        public void Enqueue(Type item)
        {
            if (IsFull())
            {
                throw new Exception("Переполнение очереди");
            }
            
            array[tail] = item;
            tail = (++tail) % lenght;
        }
        
        public Type Dequeue()
        {
            if (IsEmpty())
            {
                throw new Exception("Очередь пуста");
            } 
            
            int oldHead = head;
            head = (head + 1) % lenght;
            return array[oldHead];
        }
        
        public bool IsEmpty()
        {
            return head == tail;
        }

        public bool IsFull()
        {
            return head % lenght == (tail + 1) % lenght;
        }
    }
}