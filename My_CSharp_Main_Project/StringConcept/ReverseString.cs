using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.StringConcept
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string str = "India is my country";
            char[] ch = str.ToCharArray();
            /*foreach(char ss in ch)
            {
                Console.WriteLine(ss);
            }*/

            string reverce = "";
            for (int i = 0; i < str.Length; i++)
            {
                reverce = str[i] + reverce;
            }
            Console.WriteLine(reverce);
            /*int j = ch.Length - 1;
            for(int i=0;i<ch.Length/2;i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
            }
            string st =new string(ch);
            Console.WriteLine(st);*/
        }
    }

    //reverse word of string

    class ReverseWord
    {
        static void Main(string[] args)
        {
            string str = "India is my country";
            string[] ch = str.Split(" ");


            string reverce = "";
            for (int i = 0; i < ch.Length; i++)
            {
                string myword = ch[i];
                string word = "";
                for (int j = myword.Length - 1; j >= 0; j--)
                {
                    word = word + myword[j];
                }
                reverce = reverce + word + " ";
            }
            Console.WriteLine(reverce);
        }
    }

    class ReverseWord1
    {
        static void Main(string[] args)
        {
            string str = "India is my country hhii hhii you";
            string[] ch = str.Split(" ");


            string reverce = "";
            for (int i = 0; i < ch.Length; i++)
            {
                string myword = ch[i];
                string word = "";
                if (i == 0 || i == ch.Length - 1)
                {
                    reverce = reverce + myword + " ";
                }
                else
                {

                    for (int j = myword.Length - 1; j >= 0; j--)
                    {
                        word = word + myword[j];
                    }
                    reverce = reverce + word + " ";
                }

            }
            Console.WriteLine(reverce);
        }
    }

    //reverse word from string except fist and last word

    class DeleteElement
    {
        static void Main(string[] args)
        {
            string str = "India ";
            string str1 = "in";
            string str2 = "";


            for (int i = 0; i < str.Length; i++)
            {
                bool isSame = false;
                for (int j = 0; j < str1.Length; j++)
                {
                    if (str[i] == str1[j])
                    {
                        isSame = true;
                        break;
                    }
                }
                if (isSame == false)
                {
                    str2 = str2 + str[i];
                }

            }

            Console.WriteLine(str2);

        }
    }

}

