using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.ArrayOfCSharp
{


    //find given number occurences from the elements of array.
    class Occurence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];
            int count = 0;
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Enetr the number to find occurence:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == n)
                    count++;
            }
            Console.WriteLine("Occurences of " + n + " are " + count);
        }
    }
    //display occurences of each element of array.
    class Occurences
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Occurences are:");
            for (int i = 0; i < a.Length; i++)
            {
                bool isVisited = false;
                int count = 1;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (a[k] == a[i])
                    {
                        isVisited = true;
                        break;

                    }
                }
                if (isVisited == false)
                {
                    for (int j = i + 1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                            count++;
                    }
                    Console.WriteLine(a[i] + " :" + count);
                }

            }

        }
    }
}
