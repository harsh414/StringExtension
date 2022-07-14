using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExtension
{
    public static class StringHelper
    {
        public static int CountIndividual(this string str, char s)
        {
            int blank = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == s)
                {
                    blank++;
                }
            }
            return blank;
        }

        public static int Occurences(this string str, string word)
        {
            string[] arr = str.Split(' ');
            int count = 0;

            foreach (string s in arr)
            {
                if (word.Equals(s))
                {
                    count++;
                }
            }
            return count;
        }

        public static string CapitalizeFirstLetter(this string value)
        {
            value = value.ToLower();
            char[] array = value.ToCharArray();
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        public static void SpecialChar(this string str)
        {
            string ans = " ";
            int count = 0;
            foreach (char c in str)
            {
                if (!((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z') || c == '.' || c == '_'))
                {
                    ans += c;
                    count += 1;
                }
            }
            Console.WriteLine("all special characters are : " + ans);
            Console.WriteLine("Total special characters are : " + count);
        }
    }

}
