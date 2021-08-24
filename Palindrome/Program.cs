using System;


namespace Palindrome
{
    class Program
    {
        public static bool IsPalindrome(string palindrom)
        {

            palindrom = palindrom.Replace(" ", "").ToLower();
            int Length_String;
            Length_String = palindrom.Length;
            for (int i = 0; i < Length_String / 2; i++)
            {
                if (palindrom[i] != palindrom[Length_String - i - 1])
                {
                    Console.WriteLine("The words aren't palindrome");
                    return false;
                }
            }
            Console.WriteLine("The words are palindrome");
            return true;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the words. I will check if it is a palindrome.\n");
            var palindrome = Console.ReadLine();
            IsPalindrome(palindrome);
        }
    }
}
