using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.StringConcept
{
    class StringBasics
    {

        static void Main(string[] args)
        {
            string str = "Hello";//using keyword
            String s = "Good Day";//using literal
            String s1 = new string("How are you!");//using new keyword
            int l = s1.Length;
            Console.WriteLine(l);

            string str1 = "Hello";
            string str2 = "Hello";
            /*            Console.WriteLine(str1.GetHashCode()+" "+str2.GetHashCode());
                        Console.WriteLine(str1==str2);
                        str1 = str1 + "C#";
                        Console.WriteLine(str1 == str2);
                        Console.WriteLine(str1.GetHashCode() + " " + str2.GetHashCode());*/

            string st = string.Concat(str1, "Pune");
            Console.WriteLine(st + " " + str1);

            int x = s1.IndexOf('r');
            Console.WriteLine(s1 + " " + x);

            int x1 = s1.LastIndexOf('r');
            Console.WriteLine(s1 + " " + x1);

            string s3 = s1.Substring(4);
            Console.WriteLine(s3);

            string s4 = s1.Substring(4, 5);
            Console.WriteLine(s4);

            String s5 = "Java,C3,C,Php";
            string[] ss = s5.Split(",");

            foreach (string sss in ss)
            {
                Console.WriteLine(sss);
            }

            Console.WriteLine(string.Join("   ", "Pune", "   ", "Nashik"));

            string s6 = "      Pune        ";
            Console.WriteLine(s6);
            Console.WriteLine(s6.Trim());

            Console.WriteLine(s1.ToUpper());
            Console.WriteLine(s1.ToLower());
        }
    }


    class CountWords
    {
        static void Main(string[] args)
        {
            string str = "India is my country";
            string[] ch = str.Split(" ");
            Console.WriteLine(ch.Length);
        }
    }


    class StringCheck
    {
        static void Main(string[] args)
        {

            String s = "Hello";
            String s1 = new string("hello");

            Console.WriteLine(s == s1);
            Console.WriteLine(s.Equals(s1));

            int i = s.CompareTo(s1);
            Console.WriteLine(i);
        }
    }
}


