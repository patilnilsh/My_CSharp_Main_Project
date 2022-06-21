using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.Basics_Of_Program
{
    class DisariumNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int temp1 = n;
            int temp = n, rem = 0, rem1, mul, sum = 0;
            while (temp > 0)
            {
                rem++;
                temp = temp / 10;
            }
            while (rem >= 1)
            {
                rem1 = temp1 % 10;
                mul = 1;
                for (int i = 1; i <= rem; i++)
                {
                    mul = mul * rem1;
                }
                temp1 = temp1 / 10;
                sum = sum + mul;
                rem--;
            }
            Console.WriteLine(sum);
            if (sum == n)
                Console.WriteLine("The number is disarium");
            else
                Console.WriteLine("The number is not disarium");


        }
    }


}
