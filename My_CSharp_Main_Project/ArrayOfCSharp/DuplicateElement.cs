using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.ArrayOfCSharp
{
    //display Dublicate elements from the array.
    class Dublicate
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

    class DuplicateElement2  
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4 };
            int[] b = {44,4,77,3 };
            int[] c = new int[a.Length + b.Length];
            
            int j = 0;
            Console.WriteLine(string.Join(" ",a));

            Console.WriteLine(string.Join(" ",b));

            for (int i = 0; i < a.Length; i++)
            {
                c[j] = a[i];
                j++;
            }

            for (int i = 0; i < a.Length; i++)
            {
                bool ispresent = false;
                for (int k = j - 1; k >= 0; k--)
                {
                    if (c[k] == b[i])
                    {
                        ispresent = true;
                        break;
                    }
                }
                if (ispresent == false)
                {
                    c[j] = b[i];
                    j++;
                }
            }
            Console.WriteLine("///////////////");

            for (int i = 0; i < j; i++)
            {
                Console.WriteLine(c[i]+" ");
            }
        }
    }
}
