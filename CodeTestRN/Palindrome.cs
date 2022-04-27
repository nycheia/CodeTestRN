using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CodeTestRN
{
    public class Palindrome
    {
        public string palin;
        public int palinint;
        public Palindrome()
        {
            //this.palin = palin;
        }


        public static void checkPalindrome(string palin)
        {
            //string palinspecial = Regex.Replace(palin, @"[^\w\d]", "");
            string palinspecial = RemoveSpecialCharacters(palin);
            string reversed;
            char[] ch = palinspecial.ToCharArray();
            Array.Reverse(ch);
            reversed = new string(ch);
            //attempt to ignore spacing and special characters, did not work and ran out of time
            //string reversedIgnore = Regex.Replace(reversed, @"[^\w\d\s]", "");
            bool ic = palinspecial.Equals(reversed, StringComparison.OrdinalIgnoreCase);
            if (ic == true)
            {
                Console.WriteLine(palin + " = Palindrome");
            }
            else
            {
                Console.WriteLine(palin + " =/= Palindrome");
            }
            Console.Read();
        }

        public static string RemoveSpecialCharacters(string palin)
        {
            //return Regex.Replace(str, @"[^\w\d\s]", "");
            StringBuilder sb = new StringBuilder();
            foreach (char c in palin)
            {
                if (c >= 'A' && c <= 'z')
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }

        public static void checkPalindrome(int palin)
        {
            int reversePalin = reverseNumber(palin);

            if(reversePalin == palin)
            {
                Console.Write(palin + " = Palindrome");
            }
            else
            {
                Console.Write(palin + " =/= Palindrome");
            }
        }

        private static int reverseNumber(int n)
        {
            int revnumber = 0;
            while (n > 0)
            {
                revnumber = revnumber * 10 + n % 10;
                n = n / 10;
            }
            return revnumber;
        }

    }
}
