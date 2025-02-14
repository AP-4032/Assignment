using System;
using System.Linq;

public class Program {
    public static void Main() {
        int t = int.Parse(Console.ReadLine());

        while (t-- > 0) {
            int n = int.Parse(Console.ReadLine());
            // Using the provided method to read the array as long values.
            long[] a = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            long sum = 0, pos = 0, neg = 0;
            for (int i = 0; i < n; i++) {
                sum += a[i];
                if (a[i] >= 0)
                    pos += a[i];
                else
                    neg += -a[i];
            }

            Array.Sort(a);

            if (sum == 0) {
                Console.WriteLine("NO");
            } else {
                Console.WriteLine("YES");
                if (pos > neg) {
                    // Output in descending order.
                    for (int i = n - 1; i >= 0; i--) {
                        Console.Write(a[i] + " ");
                    }
                } else {
                    // Output in ascending order.
                    for (int i = 0; i < n; i++) {
                        Console.Write(a[i] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
