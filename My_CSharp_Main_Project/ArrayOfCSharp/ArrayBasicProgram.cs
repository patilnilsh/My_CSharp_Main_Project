using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.ArrayOfCSharp
{
    //Print reverse array.
    class Reverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];

            Console.WriteLine("Enter array elements:");
            for (int j = 0; j < a.Length; j++)
            {
                a[j] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("The array is:");
            for (int i = a.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(a[i]);
            }
        }
    }

    //print sum of array elements
    class SumOfElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];
            int sum = 0;
            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            for (int i = 0; i < a.Length; i++)
            {
                sum = sum + a[i]; ;
            }
            Console.WriteLine("The array sum is: " + sum);
        }
    }

    //Print even elements of the array.
    class EvenElements
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
            Console.WriteLine("The even elements are:");
            foreach (int x in a)
            {
                if (x % 2 == 0)
                    Console.WriteLine(x);
            }
        }
    }

    //Print prime elements of the array.
    class PrimeElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter length of array:");
            int l = int.Parse(Console.ReadLine());
            int[] a = new int[l];
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
                    Console.WriteLine(x);
            }
        }
    }

    //Print odd position elements of the array.
    class OddPosition
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
            Console.WriteLine("The odd position elements are:");
            for (int i = 0; i < a.Length; i = i + 2)
            {


                Console.WriteLine(a[i]);
            }
        }
    }

    //Print alternate elements of the array.
    class Alternate
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
            Console.WriteLine("The alternate elements are:");
            for (int i = 1; i < a.Length; i = i + 2)
            {


                Console.WriteLine(a[i]);
            }
        }
    }




    //Initialize array and display.
    class Display1
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            Console.WriteLine("Enter array elements:");
            for (int i = 0; i < a.Length; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a[i] = x;
            }
            Console.WriteLine("The array is:");
            /* for (int i = 0; i < a.Length; i++)
             {
                 Console.WriteLine(a[i]);
             }*/


            /* foreach(int x in a)
               {
                   Console.WriteLine(x);
               }*/

            //a.ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine(string.Join(" ", a));
        }
    }



    class ArrayBasicProgram
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }

    }
}
