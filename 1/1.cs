using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int[] sortedArray = SortArray(array);
        Console.WriteLine(string.Join(" ", sortedArray));

        int[] reversedArray = ReverseArray(sortedArray);
        Console.WriteLine(string.Join(" ", reversedArray));

        int[] zigzagArray = ZigzagArray(sortedArray);
        Console.WriteLine(string.Join(" ", zigzagArray));

        int isPalindrome = IsPalindrome(array) ? 1 : 0;
        Console.WriteLine(isPalindrome);

        List<int> primes = GetPrimes(sortedArray);
        Console.WriteLine(string.Join(" ", primes));

        int sum = array.Sum();
        int fibIndex = sum % 30;
        long fibonacciNumber = Fibonacci(fibIndex);
        Console.WriteLine(fibonacciNumber);
    }

    static int[] SortArray(int[] array)
    {
        int[] sortedArray = array.ToArray();
        for (int i = 0; i < sortedArray.Length - 1; i++)
        {
            for (int j = 0; j < sortedArray.Length - i - 1; j++)
            {
                if (sortedArray[j] > sortedArray[j + 1])
                {
                    int temp = sortedArray[j];
                    sortedArray[j] = sortedArray[j + 1];
                    sortedArray[j + 1] = temp;
                }
            }
        }
        return sortedArray;
    }

    static int[] ReverseArray(int[] array)
    {
        int[] reversedArray = new int[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            reversedArray[i] = array[array.Length - 1 - i];
        }
        return reversedArray;
    }

    static int[] ZigzagArray(int[] array)
    {
        int[] zigzagArray = new int[array.Length];
        int left = 0, right = array.Length - 1;
        int index = 0;
        while (left <= right)
        {
            if (left == right)
            {
                zigzagArray[index] = array[left];
            }
            else
            {
                zigzagArray[index] = array[left];
                zigzagArray[index + 1] = array[right];
                index++;
            }
            left++;
            right--;
            index++;
        }
        return zigzagArray;
    }

    static bool IsPalindrome(int[] array)
    {
        for (int i = 0; i < array.Length / 2; i++)
        {
            if (array[i] != array[array.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
    }

    static List<int> GetPrimes(int[] array)
    {
        List<int> primes = new List<int>();
        foreach (int num in array)
        {
            if (IsPrime(num))
            {
                primes.Add(num);
            }
        }
        return primes;
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static long Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        long a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            long temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }
}