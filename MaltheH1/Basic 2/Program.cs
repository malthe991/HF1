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
            Console.WriteLine(PositiveNegativeOrZero(5.24));
            Console.WriteLine(PositiveNegativeOrZero(0.0));
            Console.WriteLine(PositiveNegativeOrZero(-994.53));
            Console.WriteLine(IfSortedAscending(new int[] { 3, 7, 10}));
            Console.WriteLine(IfSortedAscending(new int[] { 74, 62, 99 }));
            Console.WriteLine(IfYearIsLeap(2016));
            Console.WriteLine(IfYearIsLeap(2018));

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
            static bool IfSortedAscending(int[] myNumbers)
            {
                for (int i = 1; i < myNumbers.Length; i++)
                {
                    if (myNumbers[i - 1] > myNumbers[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            //Positive, negative or zero
            //Given a number, write a method that checks if it is positive, negative or zero.
            static string PositiveNegativeOrZero(double number)
            {
                if (number > 0)
                {
                    return "positiv";
                }
                else if (number == 0)
                {
                    return "zero";
                }
                else return "negativ";
            }
            //If year is leap
            //Given a year as integer, write a method that checks if year is leap.}

            static bool IfYearIsLeap(int number)
            {
                if ((number % 400 == 0) || (number % 4 == 0 && number % 100 != 0))
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
