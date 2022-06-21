using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.ArrayOfCSharp
{
    class PrimeSumElement
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];
            int sum = 0;
            bool isprime = true;
            Console.WriteLine("Enter array elements:");
            for (int j = 0; j < a.Length; j++)
            {
                a[j] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The prime elements are:");
            foreach (int x in a)
            {
                isprime = true;
                for (int i = 2; i < x; i++)
                {
                    if (x % i == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime == true)
                    sum = sum + x;
            }
            Console.WriteLine("The sum of prime numbers is: " + sum);
        }
    }
}

