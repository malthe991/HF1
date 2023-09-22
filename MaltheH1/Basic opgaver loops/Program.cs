using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10x10MultiTable
{


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Multiplication Table:");
            PrintMultiplicationTable(10); // Print 10x10 multiplication table

            Console.WriteLine("\n2. The Biggest Number:");
            int[] numbers1 = { 190, 291, 145, 209, 280, 200 };
            Console.WriteLine(TheBiggestNumber(numbers1)); // Expected output: 291
            int[] numbers2 = { -9, -2, -7, -8, -4 };
            Console.WriteLine(TheBiggestNumber(numbers2)); // Expected output: -2

            Console.WriteLine("\n3. Two 7s Next to Each Other:");
            int[] arr1 = { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 };
            Console.WriteLine(Two7sNextToEachOther(arr1)); // Expected output: 1
            int[] arr2 = { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 };
            Console.WriteLine(Two7sNextToEachOther(arr2)); // Expected output: 3

            Console.WriteLine("\n4. Three Increasing Adjacent:");
            int[] sequence1 = { 45, 23, 44, 68, 65, 70, 80, 81, 82 };
            Console.WriteLine(ThreeIncreasingAdjacent(sequence1)); // Expected output: True
            int[] sequence2 = { 7, 3, 5, 8, 9, 3, 1, 4 };
            Console.WriteLine(ThreeIncreasingAdjacent(sequence2)); // Expected output: False

            Console.WriteLine("\n5. Sieve of Eratosthenes:");
            int n = 30;
            List<int> primes = SieveOfEratosthenes(n);
            Console.WriteLine(string.Join(", ", primes)); // Expected output: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29

            Console.WriteLine("\n6. Extract String M:");
            Console.WriteLine(ExtractString("##abc##def")); // Expected output: "abc"
            Console.WriteLine(ExtractString("12####78")); // Expected output: ""
            Console.WriteLine(ExtractString("gar##d#en")); // Expected output: ""
            Console.WriteLine(ExtractString("++##--##++")); // Expected output: "--"

            Console.WriteLine("\n7. Full Sequence of Letters M:");
            Console.WriteLine(FullSequenceOfLetters("ds")); // Expected output: "defghijklmnopqrs"
            Console.WriteLine(FullSequenceOfLetters("or")); // Expected output: "opqr"

            Console.WriteLine("\n8. Sum and Average:");
            int n1 = 11;
            int m1 = 66;
            Console.WriteLine(SumAndAverage(n1, m1)); // Expected output: "Sum: 2156, Average: 38.5"
            int n2 = -10;
            int m2 = 0;
            Console.WriteLine(SumAndAverage(n2, m2)); // Expected output: "Sum: -55, Average: -5"

            Console.WriteLine("\n9. Draw Triangle:");
            DrawTriangle();

            Console.WriteLine("\n10. To The Power Of:");
            int baseNumber1 = -2;
            int exponent1 = 3;
            Console.WriteLine(ToThePowerOf(baseNumber1, exponent1)); // Expected output: -8
            int baseNumber2 = 5;
            int exponent2 = 5;
            Console.WriteLine(ToThePowerOf(baseNumber2, exponent2)); // Expected output: 3125
        }

        // 1. Multiplication Table
        static void PrintMultiplicationTable(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                Console.WriteLine();
            }
        }

        // 2. The Biggest Number
        static int TheBiggestNumber(int[] numbers)
        {
            return numbers.Max();
        }

        // 3. Two 7s Next to Each Other
        static int Two7sNextToEachOther(int[] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i - 1] == 7 && arr[i] == 7)
                {
                    count++;
                }
            }
            return count;
        }

        // 4. Three Increasing Adjacent
        static bool ThreeIncreasingAdjacent(int[] sequence)
        {
            for (int i = 2; i < sequence.Length; i++)
            {
                if (sequence[i - 2] + 1 == sequence[i - 1] && sequence[i - 1] + 1 == sequence[i])
                {
                    return true;
                }
            }
            return false;
        }

        // 5. Sieve of Eratosthenes
        static List<int> SieveOfEratosthenes(int n)
        {
            bool[] isPrime = new bool[n + 1];
            for (int i = 2; i <= n; i++)
            {
                isPrime[i] = true;
            }

            for (int p = 2; p * p <= n; p++)
            {
                if (isPrime[p])
                {
                    for (int i = p * p; i <= n; i += p)
                    {
                        isPrime[i] = false;
                    }
                }
            }

            List<int> primes = new List<int>();
            for (int i = 2; i <= n; i++)
            {
                if (isPrime[i])
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        // 6. Extract String M
        static string ExtractString(string input)
        {
            int firstHashIndex = input.IndexOf("##");
            int secondHashIndex = input.LastIndexOf("##");
            if (firstHashIndex != -1 && secondHashIndex != -1 && firstHashIndex != secondHashIndex)
            {
                return input.Substring(firstHashIndex + 2, secondHashIndex - firstHashIndex - 2);
            }
            else
            {
                return string.Empty;
            }
        }

        // 7. Full Sequence of Letters M
        static string FullSequenceOfLetters(string letters)
        {
            char start = letters[0];
            char end = letters[1];

            StringBuilder result = new StringBuilder();
            for (char c = start; c <= end; c++)
            {
                result.Append(c);
            }

            return result.ToString();
        }

        // 8. Sum and Average
        static string SumAndAverage(int n, int m)
        {
            int sum = 0;
            for (int i = n; i <= m; i++)
            {
                sum += i;
            }
            double average = (double)sum / (m - n + 1);
            return $"Sum: {sum}, Average: {average:F1}";
        }

        // 9. Draw Triangle
        static void DrawTriangle()
        {
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < 2 * i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        // 10. To The Power Of
        static double ToThePowerOf(int baseNumber, int exponent)
        {
            return Math.Pow(baseNumber, exponent);
        }
    }

}

