using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.ArrayOfCSharp
{
    class UniqueElement
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
                    if (count == 1)
                        Console.WriteLine(a[i]);
                }

            }

        }
    }
}
