using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.StringConcept
{
    class UpperLowerString
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            string str1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (char.IsUpper(ch))// or if (ch >= 'A' && ch <= 'Z')
                {
                    //ch = (char)(ch + 32);
                    ch = char.ToLower(ch);
                }
                else if (char.IsLower(ch))// or if (ch >= 'a' && ch <= 'z')
                {
                    //ch = (char)(ch - 32);
                    ch = char.ToUpper(ch);
                }
                str1 = str1 + ch;
            }
            Console.WriteLine("New string:" + str1);
        }
    }
}

