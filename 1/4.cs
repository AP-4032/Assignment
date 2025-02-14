using System;
using static System.Math;

namespace river
{
    class River
    {
        static void solve()
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int n = input[0], m = input[1], k = input[2];
            int[] river = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            
            int i = -1;
            while (i < n) 
            {
                if (i < n && i >= 0 && river[i] == 1 || i < 0) {
                    
                    if (i + m >= n) {
                        i += m;
                        break;
                    }
                    int j = m;
                    while (i + j < n && i + j >= 0 && river[i + j] != 1 && j != 0) j--;
                    
                    i += j;
                    if (j == 0) {
                        j = m;
                        while (i + j < n && i + j >= 0 && river[i + j] != 0 && j != 0) j--;
                        if (j == 0) {
                            break;
                        }
                        else {
                            i += j;
                        }
                    }
                    
                }
                else if (i < n && i >= 0 && river[i] == 0) {
                    if (i < n && i >= 0 && river[i] == 0) { 
                        if (k != 0) {
                            while (k != 0 && i < n && i >= 0 && river[i] == 0) {
                                i++;
                                k--;
                            }
                        }
                        else {
                            break;
                        }
                    }
                }
                else {
                    break;
                }
            }
            if (i >= n) 
            {
                Console.WriteLine("YES");
            }
            else 
            {
                Console.WriteLine("NO");
            }
        }
        static void Main()
        {
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++) 
            {
                solve();
            }
        }
    }
}
