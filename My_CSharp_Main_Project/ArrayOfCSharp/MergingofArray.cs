using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.ArrayOfCSharp
{
    class MergingofArray
    {

        static void Main(string[] args)
        {
            int[] a = { 4, 5, 6, 1, 2 };
            int[] b = { 7, 8, 9, 4 };
            int length = a.Length + b.Length;
            int[] c = new int[length];
            int i, j;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (j = 0; j < b.Length; j++)
            {
                c[i] = b[j];
                i++;
            }
            /*foreach(int x in c)
            {
                Console.WriteLine(x);
            }*/
            Console.WriteLine(string.Join(" ", c));
        }
    }

    //Print unique elements of array after mearging
    class UniqueArray
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 2, 6, 1, 4, 2 };
            int[] b = { 7, 8, 9, 5, 4 };
            int length = a.Length + b.Length;
            int[] c = new int[length];
            int i, j;
            for (i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (j = 0; j < b.Length; j++)
            {
                c[i] = b[j];
                i++;
            }
            for (i = 0; i < c.Length; i++)
            {
                bool isVisited = false;

                for (int k = i - 1; k >= 0; k--)
                {
                    if (c[k] == c[i])
                    {
                        isVisited = true;
                        break;

                    }
                }
                if (isVisited == false)
                {
                    Console.Write(c[i] + " ");
                }
            }
            Console.WriteLine();
            /*foreach(int x in c)
            {
                Console.WriteLine(x);
            }*/
            Console.WriteLine(string.Join(" ", c));
        }
    }

    //mearge two arrays into alternate position
    class MeargeAlternate
    {
        static void Main(string[] args)
        {
            int[] a = { 4, 5, 2, 6, 1, 4 };
            int[] b = { 7, 8, 9, 5, 4 };
            int length = a.Length + b.Length;
            int[] c = new int[length];
            int i = 0, j = 0;
            for (int k = 0; k <= c.Length; k++)
            {
                if ((k == 0 || k % 2 == 0) && i < a.Length)
                {
                    c[k] = a[i];
                    i++;
                }
                else if ((k % 2 == 1) && j < b.Length)
                {
                    c[k] = b[j];
                    j++;
                }



            }
            Console.WriteLine(string.Join(" ", c));
        }
    }
}

