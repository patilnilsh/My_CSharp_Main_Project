using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.ArrayOfCSharp
{ 
    //sort array in accending array.
    class SortingArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            char[] a = new char[l];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToChar(Console.ReadLine());

            }
            Console.WriteLine("..................Before...................");
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        char temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }




                }
            }
            Console.WriteLine("..................After........................");
            Console.WriteLine(string.Join(" ", a));
        }
    }


    //sort array in Descending array.
    class SortDescending
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            char[] a = new char[l];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToChar(Console.ReadLine());

            }
            Console.WriteLine("..................Before...................");
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        char temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }




                }
            }
            Console.WriteLine("..................After........................");
            Console.WriteLine(string.Join(" ", a));
        }
    }


    //sort integer array in accending array.
    class SortAssending1
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
            Console.WriteLine("..................Before...................");
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }




                }
            }
            Console.WriteLine("..................After........................");
            Console.WriteLine(string.Join(" ", a));
        }
    }

    //sort integer array in deccending array.
    class SortDescending1
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
            Console.WriteLine("..................Before...................");
            Console.WriteLine(string.Join(" ", a));
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }




                }
            }
            Console.WriteLine("..................After........................");
            Console.WriteLine(string.Join(" ", a));
        }
    }
}

