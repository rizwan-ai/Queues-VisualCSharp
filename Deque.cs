using System;
using static System.Console;

namespace DEQUE
{
    public class Deque
    {
        private int[] QU; 
        private int F, R; 
        public Deque(int size)
        {
            QU = new int[size];
            F = R = -1;
        }
        public void EnqueueFront(int x)
        {
            if (F == 0 && R == QU.Length-1)
            {
                WriteLine("Deque is Full");
                return;
            }
            if (F == -1 && R == -1)
            {
                F = R = 0;
                QU[F] = x;
            }
            else if (F > 0)
            {
                F--;
                QU[F] = x;
            }
            else
                WriteLine("No space from front side");
        }
        public void EnqueueRear(int x)
        {
            if (F == 0 && R == QU.Length-1)
            {
                WriteLine("Deque is Full");
                return;
            }
            if (F == -1 && R == -1)
            {
                F = R = 0;
                QU[R] = x;
            }
            else if (R < QU.Length-1)
            {
                R++;
                QU[R] = x;
            }
            else
            {
                WriteLine("No space from rear side");
            }
        }
        public void DequeueFront()
        {
            if (F == -1 && R == -1)
            {
                WriteLine("Deque is Empty");
                return;
            }
            else
                QU[F] = 0;
            if (F == R)
                F = R = -1;
            else
                F++;
        }
        public void DequeueRear()
        {
            if (F == -1 && R == -1)
            {
                WriteLine("Deque is Empty");
                return;
            }
            else
                QU[R] = 0;
            if (F == R)
                F = R = -1;
            else
                R--;
        }
        public void Display()
        {
            if (F == -1 && R == -1)
            {
                WriteLine("Deque is Empty");
                return;
            }
            WriteLine("Values in Deque ...");
            for (int i = F; i <= R; i++)
            {
                WriteLine(QU[i]);
            }
        }
    }
}