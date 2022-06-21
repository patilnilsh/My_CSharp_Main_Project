using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.StringConcept
{
    class StringDigitAdd  //display digit of the string and print addition of that
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();

            double sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    Console.WriteLine(str[i]);
                    double x = char.GetNumericValue(str[i]);
                    sum = sum + x;
                }
            }
            Console.WriteLine("sum=" + sum);
        }
    }
}
