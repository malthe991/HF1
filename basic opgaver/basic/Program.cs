using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Reflection;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
//hej
namespace basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = AddAndMultiply(2, 4, 5);
            Console.WriteLine(result);
            Console.WriteLine(CelsiusToFahrenheit(0));
            Console.WriteLine(CelsiusToFahrenheit(100));
            Console.WriteLine(CelsiusToFahrenheit(-300));
            Console.WriteLine(ElementaryOperations(3, 8)[0]);
            Console.WriteLine(ElementaryOperations(3, 8)[1]);
            Console.WriteLine(ElementaryOperations(3, 8)[2]);
            Console.WriteLine(ElementaryOperations(3, 8)[3]);
            Console.WriteLine(IsResultTheSame(2 + 2, 2 * 2));
            Console.WriteLine(IsResultTheSame(9 / 3, 16 - 1));
            Console.WriteLine(ModuloOperations(8, 5, 2));
            Console.WriteLine(TheCubeOf(2));
            Console.WriteLine(TheCubeOf(-5.5m));
            Console.WriteLine(SwapTwoNumbers(87, 45));




        }
        //Add two numbers
        //Given three numbers, write a method that adds two first ones and multiplies them by a third one.
        static int AddAndMultiply(int firstNumber, int secondNumber, int thirdNumber)
        {
            int output =(firstNumber + secondNumber) * thirdNumber;

            return output;
        }
        //Celsius to Fahrenheit
        //Given a temperature in Celsius degrees, write a method that converts it to Fahrenheit degrees.Remember that temperature below -271.15°C (absolute zero) does not exist!
        static string CelsiusToFahrenheit( float celsius)
        {
            if (celsius < -271.15)
            {
                return "Temperature below absolute zero!";
            }
            else
            {
                float fahrenheit = ((celsius * 9) / 5) + 32;
                return fahrenheit.ToString();
            }
        }
        //Elementary operations
        //Given two integers, write a method that returns results of their elementary arithmetic operations: addition, substraction, multiplication, division.Remember that you can't divide any number by 0!
        static decimal[] ElementaryOperations(decimal number1, decimal number2)
        {
            decimal[] result = new decimal[4];
            result[0] = number1 + number2;
            result[1] = number1 * number2;
            result[2] = number1 - number2;
            if (number1 != 0 && number2 != 0)
            {
                result[3] = number1 / number2;
            }
            else
            {
                result[3] = 0;
            }
            return result;
        }
        //Is result the same
        //Given two different arithmetic operations(addition, subtraction, multiplication, division), write a method that checks if they return the same result.
        static bool IsResultTheSame(int number1, int number2)
        {
            if (number1 == number2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Modulo operations
        //Given three integers, write a method that returns first number divided modulo by second one and these divided modulo by third one.
        static int ModuloOperations(int number1, int number2, int number3)
        {
            return(number1 % number2) % number3;
        }
       //The cube of
       //Given a number, write a method that returns its cube.
       static decimal TheCubeOf(decimal number1)
        {
            return number1 * number1 * number1;
        }
        //Swap two numbers
        //Given two integers, write a method that swaps them using temporary variable.
        static string SwapTwoNumbers(int number1, int number2)
        {
            string before = $"before number1 = {number1} , number2 = {number2}. ";
            int temp = number1;
            number1 = number2;
            number2 = temp;
            string after = $"After number1 = {number1} , number2 = {number2} ";

            return before + after ;
        }

    }
}