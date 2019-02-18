using System;
using static System.Console;

namespace LinearQueue
{
    public class LinearQ
    {
        private int[] QU;
        private int F, B;
        public LinearQ(int size)   
        {
            QU = new int[size];
            F = B = -1;
        }
        public void Enqueue(int x)  // Insertion
        {
            if (B == QU.Length - 1)
            {
                WriteLine("Queue is Full");
                return;
                // throw new Exception("Queue is Full");
            }
            else
            {
                QU[++B] = x;
                WriteLine($"Value {x} is Inserted!");
            }
            if (F == -1)
                F = 0;
        }
        public void Dequeue()       // Deletion 
        {
            if (F == -1)
            {
                WriteLine("Queue is Empty");
                return;
            }
            else
            {
                WriteLine($"Value {QU[F]} is removed!");
                QU[F++] = 0;
            }
            if (F > B)
                F = B = -1;
        }
        public void Display()
        {
            if (F == -1)
            {
                WriteLine("Queue is Empty");
                return;
            }
            WriteLine("Values in queue ...");
            for (int i = F; i <= B; i++)
            {
                WriteLine(QU[i]);
            }
        }
        public int Peek()
        {
            return QU[F];
        }
        public bool IsFull()
        {
            if (B == QU.Length - 1)
                return true;
            else
                return false;
        }
        public bool IsEmpty()
        {
            if (F == -1)
                return true;
            else
                return false;
        }
    }
}