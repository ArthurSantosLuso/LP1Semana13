using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using static System.Net.Mime.MediaTypeNames;

namespace Palindrome
{
    public class Program
    {
        private static void Main(string[] args)
        {
            foreach (string word in args)
            {
                Console.WriteLine($"{word} -> {IsPalindrome(word)}");
            }

        }

        private static bool IsPalindrome(string text)
        {
            bool Palindrome(string word)
            {
                string str = word;
                char[] cArray = str.ToCharArray();
                Array.Reverse(cArray);
                string revStr = new string(cArray);

                return str == revStr ? true : false;
            }


            if (text == null) throw new ArgumentNullException();

            if (text.Length > 0 && text.Length < 2)
            {
                return true;
            }
            else
            {
                return Palindrome(text);
            }
        }
    }
}
