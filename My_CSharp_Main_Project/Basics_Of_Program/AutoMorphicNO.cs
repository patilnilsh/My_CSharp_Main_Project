using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.Basics_Of_Program
{
    class AutoMorphicNO
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int m = n * n;
            int temp = n, rem = 0;
            while (temp > 0)
            {
                rem++;
                temp = temp / 10;
            }
            int power = 1;
            while (rem > 0)
            {
                power = power * 10;
                rem--;
            }
            int end = m % power;

            if (end == n)
                Console.WriteLine("The given number is automorphic");
            else
                Console.WriteLine("The given number is not automorphic");

        }
    }
}

