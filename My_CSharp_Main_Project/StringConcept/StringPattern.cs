using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.StringConcept
{
    class StringPattern
    {

        static void Main(string[] args)
        {
            string str = "India is my country";
            string[] ch = str.Split(" ");
            for (int i = 0; i < ch.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(ch[j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
