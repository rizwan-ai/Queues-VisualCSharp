using System;
using static System.Console;

namespace CircularQueue
{
    public class CircularQ
    {
        private int[] QU;
        private int F, B;
        public CircularQ(int size)
        {
            QU = new int[size];
            F = B = -1;
        }
        public void Enqueue(int x)
        {
            if (F == (B + 1) % QU.Length)
            {
                WriteLine("CQ is Full");
                return;
            }
            else
            {
                B = (B + 1) % QU.Length;
                QU[B] = x;
                WriteLine($"Value {x} is Inserted!");
            }
            if (F == -1)
                F = 0;
        }
        public void Dequeue()
        {
            if (F == -1 && B == -1)
            {
                WriteLine("CQ is Empty");
                return;
            }
            else
            {
                WriteLine($"Value {QU[F]} is removed!");
                QU[F] = 0;
            }
            if (F == B)
                F = B = -1;
            else
                F = (F + 1) % QU.Length;
        }
    }
}