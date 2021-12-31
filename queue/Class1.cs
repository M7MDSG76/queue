using System;
using System.Collections.Generic;
using System.Text;

namespace queue
{
    class queue
    {
        private int[] arr;
        private int front;
        private int rear;
        private int capacity;
        private int count;
       public queue(int size)
        {
            arr = new int [size];
            front = 0;
            rear = -1;
            capacity = size;
            count = 0;
        }
        public int Size()
        {
            return count;
        }
       
        public bool IsEmpty()
        {
            return (Size() == 0);
            
        }
        public bool IsFull()
        {
            return (Size() == capacity);
        }
        public int Peek()
        {
            if (IsEmpty())
                Console.WriteLine("Queue is Empty.");
            return arr[front];
        }
        public void Enqueue(int num)
        {
            Console.WriteLine("Element added is: " + num);
            rear = (rear + 1) % capacity;
            arr[rear] = num;
            count++;
        }
        public void Dequeue()
        {
            Console.WriteLine("Element deleted is: " + arr[front]);
            arr[front] = 0;
            front = (front + 1) % capacity;
            count--;
        }
        public void PrintQueue()
        {
            Console.WriteLine();
            for(int i = 0; i < capacity; i++)
            {
                Console.Write(arr[i]+"\t");
            }
            Console.WriteLine();
        }

    }
}
