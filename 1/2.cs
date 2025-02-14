using System;
using static System.Math;

namespace comet
{
    class Comet
    {
        static void drawLine(long n)
        {
            if (n == 0) 
            {
                Console.WriteLine();
                return;
            }
            Console.Write("*");
            drawLine(n - 1);
        }
        static void drawTriangle(long n) 
        {
            if (n == 1)
            {
                drawLine(n);
                return;
            }
            drawTriangle(n - 1);
            drawLine(n);
        }
        static long getSequenceItem(long n, long k)
        {
            if (n == 1) { return 1; }

            long mid = (long)Math.Pow(2, n - 1);

            if (k == mid)
                return n;
            else if (k < mid)
                return getSequenceItem(n - 1, k);
            else
                return getSequenceItem(n - 1, k - mid);
        }
        static void Main()
        {
            long[] input = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
            long n = input[0], k = input[1];
            long size = getSequenceItem(n, k);
            drawTriangle(size);
        }
    }
}
