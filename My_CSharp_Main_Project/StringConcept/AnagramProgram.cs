using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.StringConcept
{
    class AnagramProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1st string");
            string str = Console.ReadLine();
            Console.WriteLine("Enter 2nd string");
            string str1 = Console.ReadLine();

            string st = str.ToLower();
            string st1 = str1.ToLower();

            char[] ch = st.ToCharArray();
            char[] ch1 = st1.ToCharArray();

            Array.Sort(ch);
            Array.Sort(ch1);

            Console.WriteLine("///////////////////////////////////////////////");
            Console.WriteLine(string.Join(" ", ch));
            Console.WriteLine(string.Join(" ", ch1));

            if (ch.Length == ch1.Length)
            {
                bool flag = true;

                for (int i = 0; i < ch.Length; i++)
                {
                    if (ch[i] != ch1[i])
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag == true)
                    Console.WriteLine("Strings are Anagram");
                else
                    Console.WriteLine("Strings not are Anagram");

                /*string st2 = new string(ch);
                string st3 = new string(ch1);

                if (st2.Equals(st3))
                {
                    Console.WriteLine("Strings are Anagram");

                }
                else
                    Console.WriteLine("String Not Anagram");*/
            }
            else
                Console.WriteLine("The length of both strings are not same so this are noot anagram strings");

        }
    }

}

