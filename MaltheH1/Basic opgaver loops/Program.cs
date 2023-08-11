using System;
using System.ComponentModel;
using System.Threading.Channels;

namespace Loops
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("RegneTabel:");
            RegneTabel(10);
            Console.Write("\n");
            Console.WriteLine("The biggest number:");
            Console.WriteLine(TheBiggestNumber(new int[] { 190, 291, 145, 209, 280, 200 }));
            Console.WriteLine(TheBiggestNumber(new int[] { -9, -2, -7, -8, -4 }));
            Console.Write("\n");
            Console.WriteLine("Two 7s next to each other:");
            Console.WriteLine(Two7sNextToEachOther(new int[] { 8, 2, 5, 7, 9, 0, 7, 7, 3, 1 }));
            Console.WriteLine(Two7sNextToEachOther(new int[] { 9, 4, 5, 3, 7, 7, 7, 3, 2, 5, 7, 7 }));
            Console.Write("\n");
            Console.WriteLine("Three increasing adjacent:");

            Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 45, 23, 44, 68, 65, 70, 80, 81, 82 }));
            Console.WriteLine(ThreeIncreasingAdjacent(new int[] { 7, 3, 5, 8, 9, 3, 1, 4 }));
            Console.Write("\n");
            Console.WriteLine("Sieve of Eratosthenes:");
            int value = 30;
            List<int> primes = PrimeNumber(value);

            string primeNumbersString = string.Join(", ", primes);
            Console.WriteLine("Prime numbers up to " + value + ": " + primeNumbersString);
            Console.Write("\n");
            Console.WriteLine("Extract string:");
            Console.WriteLine(ExtractString("##abc##def"));
            Console.WriteLine(ExtractString("12####78"));
            Console.WriteLine(ExtractString("gar##d#en"));
            Console.WriteLine(ExtractString("++##--##++"));

            Console.ReadKey();

        }
        //Multiplication table
        //Write a method that prints 10 by 10 multiplication table.Remember readability (spaces in the right place).
        public static void RegneTabel(int size)
        {
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    int tabel = i * j;
                    Console.Write($"{tabel,4}"); //Mellemrum i tabel
                }
                Console.WriteLine();
            }
        }
        //The biggest number
        //Given an array of integers, write a method that returns the biggest number in this array.
        static int TheBiggestNumber(int[] array)
        {
            return array.Max(x =>x); // Vælger den højste værdi
        }

        //Two 7s next to each other
        //Given an array of positive digits, write a method that returns number of times that two 7's are next to each other in an array.
        static int Two7sNextToEachOther(int[] array)
        {
            int next = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == 7 && array[i +1] == 7) 
                {
                    next++;
                }
            }
            return next;
        }
        //Three increasing adjacent
        //Given an array of numbers, write a method that checks if there are three adjacent numbers where second is greater by 1 than the first one and third is greater by 1 than the second one.
        static bool ThreeIncreasingAdjacent(int[] array)
        {
            bool Adjacent = false;
            for (int i = 1;i <= array.Length - 2;i++)
            {
                if (array[i -1] + 1 == array[i] && array[i + 1] -1 == array[i] )
                {
                    Adjacent = true;
                }
            }
            return Adjacent;
        }
        //Sieve of Eratosthenes
        //Given an integer n(n>2), write a method that returns prime numbers from range[2, n].
        public static List<int> PrimeNumber(int value)
        {
            List<int> primes = new List<int>();
            bool[] isComposite = new bool[value + 1]; // We'll use this to mark non-prime numbers

            for (int number = 2; number <= value; number++)
            {
                if (!isComposite[number]) // If the number is not marked as composite (non-prime)
                {
                    primes.Add(number); // It's a prime, so add it to the list

                    // Now mark all multiples of this prime as composite
                    for (int multiple = 2 * number; multiple <= value; multiple += number)
                    {
                        isComposite[multiple] = true;
                    }
                }
            }

            return primes;
        }
        //Extract string M
        //Given a string, write a method that returns substring from between two double hash signs(#).

       static string ExtractString(string value)
        {
            int start = value.IndexOf("##");
            if (start == -1)
            {
                return string.Empty;
            }
            int slut = value.IndexOf("##", start +2);
            if (slut == -1)
            {
                return string.Empty;
            }
            start += 2;
            string output = value.Substring(start, slut - start);
            return output;
        }

    }

}   