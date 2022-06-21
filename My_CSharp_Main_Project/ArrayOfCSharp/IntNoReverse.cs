using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.ArrayOfCSharp
{
    class IntNoReverse
    {

        //create original array to reverse array.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];
            int temp, j = a.Length - 1;
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int i = 0; i < a.Length / 2; i++)
            {
                temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;

            }
            Console.WriteLine("The array is:");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }
    }
}
    

