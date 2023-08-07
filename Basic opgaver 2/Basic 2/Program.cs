using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Threading;

namespace Basic_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine(AbsoluteValute(6832));
            Console.WriteLine(AbsoluteValute(-392));
            Console.WriteLine(DivisibleBy2Or3(15, 30));
            Console.WriteLine(DivisibleBy2Or3(2, 90));
            Console.WriteLine(DivisibleBy2Or3(7, 12));
            Console.WriteLine(IfConsistsOfUppercaseLetters("xyz"));
            Console.WriteLine(IfConsistsOfUppercaseLetters("DOG"));
            Console.WriteLine(IfConsistsOfUppercaseLetters("L9#"));
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 2, 7, 12 }));
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { -5, -8, 50 }));
            Console.WriteLine(IfNumberIsEven(721));
            Console.WriteLine(IfNumberIsEven(1248));
            //Absolute value
            //Given an integer, write a method that returns its absolute value.
            static int AbsoluteValute(int number1)
            {
                return Math.Abs(number1);
            }


            //Divisible by 2 or 3
            //Given two integers, write a method that returns their multiplication if they are both divisible by 2 or 3, otherwise returns thier sum.
            static int DivisibleBy2Or3(int number1, int number2)
            {
                if ((number1 % 2 == 0 || number1 % 3 == 0) && (number2 % 2 == 0 || number2 % 3 == 0))
                {
                    return number1 * number2;
                }
                else
                {
                    return number1 + number2;
                }
            }


            //If consists of uppercase letters
            //Given a 3 characters long string, write a method that checks if it consists only of uppercase letters.
            static bool IfConsistsOfUppercaseLetters(string text)
            {
                if (text.Length == 3)
                {
                    foreach (char c in text)
                    {
                        if (!Char.IsUpper(c))
                        {
                            return false;
                        }
                    }
                    return true;
                }
                else
                {
                    return false;
                }
            }
            //If greater than third one
            //Given an array of 3 integers, write a method that checks if multiplication or sum of two first numbers is greater than third one.
            static bool IfGreaterThanThirdOne(int[] array)
            {
                return array[0] + array[1] > array[2] || array[0] * array[1] > array[2];
            }


            //If number is even
            //Given an integer, write a method that checks if it is even.
            static bool IfNumberIsEven(int number1)
            {
                bool output = false;
                if (number1 % 2 == 0)
                {
                    output = true;
                }
                return output; 
            }
            //If sorted ascending
            //Given an array of three integers, write a method that checks if they are sorted in ascending order.
            static bool IfSortedAscending(int[] array)
            {                                                            

            }

        }
    }
}
