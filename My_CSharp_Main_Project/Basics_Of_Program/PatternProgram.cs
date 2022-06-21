using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.Basics_Of_Program
{   
    

    class PatternProgram
    {

        /*    * * * *
          * * * *
          * * * *
          * * * *   */

        class pattern1
        {
            static void Main(string[] args)
            {

                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 4; j++)
                    {
                        Console.Write(" *");
                    }
                    Console.WriteLine();
                }
            }
        }



        /*         * 
                   * * 
                   * * * 
                   * * * *   */

        class pattern2
        {
            static void Main(string[] args)
            {

                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" *");
                    }
                    Console.WriteLine();
                }
            }
        }

        /*         * * * *
                   * * * 
                   * * 
                   *         */

        class pattern3
        {
            static void Main(string[] args)
            {

                for (int i = 4; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" *");
                    }
                    Console.WriteLine();
                }
            }
        }

        /*        1
                  2 2
                  3 3 3
                  4 4 4 4     */

        class pattern4
        {
            static void Main(string[] args)
            {

                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" " + i);
                    }
                    Console.WriteLine();
                }
            }
        }

        /*        1
                  1 2
                  1 2 3
                  1 2 3 4     */

        class pattern5
        {
            static void Main(string[] args)
            {

                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" " + j);
                    }
                    Console.WriteLine();
                }
            }
        }


        /*       1 2 3 4
                 1 2 3
                 1 2
                 1     */

        class pattern6
        {
            static void Main(string[] args)
            {

                for (int i = 4; i >= 1; i--)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" " + j);
                    }
                    Console.WriteLine();
                }
            }
        }



        /*      4 3 2 1
                4 3 2
                4 3
                4     */

        class pattern7
        {
            static void Main(string[] args)
            {

                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 4; j >= i; j--)
                    {
                        Console.Write(" " + j);
                    }
                    Console.WriteLine();
                }
            }
        }


        /*      1 
                2 3
                4 5 6
                7 8 9 10     */

        class pattern8
        {
            static void Main(string[] args)
            {
                int count = 1;
                for (int i = 1; i <= 5; i++)
                {

                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write(" " + count);
                        count++;
                    }

                    Console.WriteLine();
                }
            }
        }


        /*     * * * *
               *     *
               *     *
               * * * *     */

        class pattern9
        {
            static void Main(string[] args)
            {

                for (int i = 1; i <= 4; i++)
                {

                    for (int j = 1; j <= 4; j++)
                    {
                        if (i == 1 || i == 4 || j == 1 || j == 4)
                            Console.Write(" *");
                        else
                            Console.Write("  ");
                    }

                    Console.WriteLine();
                }
            }
        }

        //number is triometric or not

        class triomorphic1
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the number:");
                int n = int.Parse(Console.ReadLine());
                int m = n * n * n;
                int r = m % 10;
                if (r == n)
                    Console.WriteLine("The given number is triomorphic");
                else
                    Console.WriteLine("The given number is not triomorphic");

            }
        }

    }


    /*     * 
         * *
         *   *
         * * * *     */

    class pattern10
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <= 4; i++)
            {

                for (int j = 1; j <= i; j++)
                {
                    if (i == 4 || i == j || j == 1)
                        Console.Write(" *");
                    else
                        Console.Write("  ");
                }

                Console.WriteLine();
            }
        }
    }


    /*             *
                  * *
                 * * *
                * * * *     */

    class pattern11
    {
        static void Main(string[] args)
        {
            int max = 4;
            int temp = max;
            for (int i = 0; i < temp; i++)
            {

                for (int j = 1; j <= 7; j++)
                {
                    if (j >= max && j <= (max + (2 * i)))
                    {
                        if (i == 0 || i % 2 == 0)
                        {
                            if (j % 2 == 0)
                                Console.Write(" *");
                            else
                                Console.Write("  ");
                        }
                        else
                        {
                            if (j % 2 == 1)
                                Console.Write(" *");
                            else
                                Console.Write("  ");
                        }
                    }
                    else
                        Console.Write("  ");

                }
                max--;
                Console.WriteLine();


            }
        }
    }

    /*            1 0 1 0 1
                  0 1 0 1 0
                  1 0 1 0 1
                  0 1 0 1 0
                  1 0 1 0 1    */

    class pattern12
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 2; i <= 6; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    if (i % 2 == 0)
                    {
                        if (j % 2 == 1)
                            Console.Write("1");
                        else
                            Console.Write("0");
                    }
                    else
                    {
                        if (j % 2 == 1)
                            Console.Write("0");
                        else
                            Console.Write("1");

                    }
                }
                Console.WriteLine();
            }




        }
    }


    /*             1
                  333
                 55555
                7777777     */

    class pattern13
    {
        static void Main(string[] args)
        {
            int max = 4;
            int temp = max;
            int k = 1;
            for (int i = 0; i < temp; i++)
            {

                for (int j = 1; j <= 7; j++)
                {


                    if (j >= max && j <= (max + (2 * i)))
                        Console.Write(k);
                    else
                        Console.Write(" ");


                }
                max--;
                Console.WriteLine();
                k += 2;


            }
        }
    }

    /*           1
                 1 0
                 1 0 1
                 1 0 1 0
                 1 0 1 0 1   */

    class pattern14
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    if (j % 2 == 1)
                        Console.Write("1");
                    else
                        Console.Write("0");
                }
                Console.WriteLine();
            }




        }
    }
}





