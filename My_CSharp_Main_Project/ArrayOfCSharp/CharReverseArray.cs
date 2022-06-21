using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.ArrayOfCSharp
{
    class CharReverseArray
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            char[] a = new char[l];
            char temp;
            int j = a.Length - 1;
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToChar(Console.ReadLine());

            }
            for (int i = 0; i < a.Length / 2; i++)
            {
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;

            }
            Console.WriteLine("The array is:");
            Console.WriteLine(string.Join(" ", a));
        }
    }
}
