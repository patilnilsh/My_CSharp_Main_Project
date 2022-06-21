using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.Basics_Of_Program
{
    class KarpekerNO
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int m = n * n;
            int rem = 0, sum = 0;
            while (m > 0)
            {
                rem = m % 10;
                sum = sum + rem;
                m = m / 10;
            }

            if (sum == n)
                Console.WriteLine("The given number is cartbreaker");
            else
                Console.WriteLine("The given number is not cartbreaker");

        }
    }


}

