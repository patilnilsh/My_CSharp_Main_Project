using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.ArrayOfCSharp
{
    class MethodOfArray
    {
        int[] Dosort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])

                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }
        static void Main(string[] args)
        {
            int[] a = { 5, 6, 2, 8, 5, 0 };
            MethodOfArray b = new MethodOfArray();
            int[] newArray = b.Dosort(a);
            Console.WriteLine(string.Join(" ", newArray));
        }
    }
}

