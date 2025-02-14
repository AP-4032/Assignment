using System;
using static System.Math;

namespace taxi
{
    class Taxi
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] groups = {0, 0, 0, 0};
            for (int i = 0; i < n; i++)
            {
                groups[arr[i] - 1]++;
            }
            int taxiCount = 0;

            // Handle taxi for groups of four
            taxiCount += groups[3];
            
            
            // Handle taxi for groups of three and one
            int Min1_3 = Math.Min(groups[0], groups[2]);
            taxiCount += Min1_3;
            groups[0] -= Min1_3;
            groups[2] -= Min1_3;
            
            // Handle taxi for groups of two
            taxiCount += groups[1] / 2;
            groups[1] = groups[1] % 2;
            
            // Handle taxi for groups of three if no 1 remaining
            int Threes = groups[2];
            taxiCount += Threes;
            groups[2] = 0;
            
            // Handle taxi for groups of two and 2 ones
            if (groups[1] > 0) 
            {
                taxiCount++;
                groups[0] = groups[0] - 2 <= 0 ? 0 : groups[0] - 2;
                groups[1] = 0;
            }
            
            // Handle taxi for groups of one
            taxiCount += (int)Math.Ceiling((double)groups[0]/(double)4);
            Console.WriteLine(taxiCount);
        }
    }
}
