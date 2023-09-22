using System;
using System.Text;

namespace Basic3
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Add Separator:");
            Console.WriteLine(AddSeparator("ABCD", "^")); // Expected output: "A^B^C^D^"
            Console.WriteLine(AddSeparator("chocolate", "-")); // Expected output: "c-h-o-c-o-l-a-t-e"

            Console.WriteLine("\n2. Is Palindrome:");
            Console.WriteLine(IsPalindrome("eye")); // Expected output: true
            Console.WriteLine(IsPalindrome("home")); // Expected output: false

            Console.WriteLine("\n3. Length of String:");
            Console.WriteLine(LengthOfAString("computer")); // Expected output: 8
            Console.WriteLine(LengthOfAString("ice cream")); // Expected output: 9

            Console.WriteLine("\n4. String in Reverse Order:");
            Console.WriteLine(StringInReverseOrder("qwerty")); // Expected output: "ytrewq"
            Console.WriteLine(StringInReverseOrder("oe93 kr")); // Expected output: "rk 39eo"

            Console.WriteLine("\n5. Number of Words:");
            Console.WriteLine(NumberOfWords("This is sample sentence")); // Expected output: 4
            Console.WriteLine(NumberOfWords("OK")); // Expected output: 1

            Console.WriteLine("\n6. Revert Words Order:");
            Console.WriteLine(RevertWordsOrder("John Doe.")); // Expected output: "Doe John."
            Console.WriteLine(RevertWordsOrder("A, B. C")); // Expected output: "C B. A,"

            Console.WriteLine("\n7. How Many Occurrences:");
            Console.WriteLine(HowManyOccurrences("do it now", "do")); // Expected output: 1
            Console.WriteLine(HowManyOccurrences("empty", "d")); // Expected output: 0

            Console.WriteLine("\n8. Sort Characters Descending:");
            Console.WriteLine(SortCharactersDescending("onomatopoeia")); // Expected output: "tpoooonmieaa"
            Console.WriteLine(SortCharactersDescending("fohjwf42os")); // Expected output: "wsoojhff42"

            Console.WriteLine("\n9. Compress String:");
            Console.WriteLine(CompressString("kkkktttrrrrrrrrrr")); // Expected output: "k4t3r10"
            Console.WriteLine(CompressString("p555ppp7www")); // Expected output: "p153p371w3"
        }

        // 1. Add Separator
        static string AddSeparator(string input, string separator)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                result.Append(input[i]);
                if (i < input.Length - 1)
                {
                    result.Append(separator);
                }
            }
            return result.ToString();
        }

        // 2. Is Palindrome
        static bool IsPalindrome(string input)
        {
            int left = 0;
            int right = input.Length - 1;
            while (left < right)
            {
                if (input[left] != input[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }

        // 3. Length of String
        static int LengthOfAString(string input)
        {
            int length = 0;
            foreach (char c in input)
            {
                length++;
            }
            return length;
        }

        // 4. String in Reverse Order
        static string StringInReverseOrder(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 5. Number of Words
        static int NumberOfWords(string input)
        {
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        // 6. Revert Words Order
        static string RevertWordsOrder(string input)
        {
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Array.Reverse(words);
            return string.Join(" ", words);
        }

        // 7. How Many Occurrences
        static int HowManyOccurrences(string input, string substring)
        {
            int count = 0;
            int index = input.IndexOf(substring);
            while (index != -1)
            {
                count++;
                index = input.IndexOf(substring, index + 1);
            }
            return count;
        }

        // 8. Sort Characters Descending
        static string SortCharactersDescending(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Sort(charArray);
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 9. Compress String
        static string CompressString(string input)
        {
            StringBuilder compressed = new StringBuilder();
            char currentChar = input[0];
            int count = 1;

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] == currentChar)
                {
                    count++;
                }
                else
                {
                    compressed.Append(currentChar);
                    compressed.Append(count);
                    currentChar = input[i];
                    count = 1;
                }
            }

            compressed.Append(currentChar);
            compressed.Append(count);

            return compressed.ToString();
        }
    }

}