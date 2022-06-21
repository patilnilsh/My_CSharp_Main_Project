using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.Basics_Of_Program
{
    class MenuDrivenProgram
    {
        //boolean

        class bool1
        {
            static void Main(string[] args)
            {
                int i = -10;
                for (; Convert.ToBoolean(Convert.ToInt32(i)); Console.WriteLine(i++)) ;
            }
        }


        //example od dowhile

        class dowhile
        {
            static void Main(string[] args)
            {
                int i = 1;
                do
                {
                    Console.WriteLine(i);
                    i++;

                } while (i > 10);
            }
        }

        // menudriven of simple calculator
        class menudriven
        {
            static void Main(string[] args)
            {
                char ch;
                do
                {
                    Console.WriteLine("Enter any two numbers:");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine("1.Addition \n 2.Substraction \n 3.Multiplication \n 4.Division");
                    Console.WriteLine("Enter choice which operation you can perform:");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("The addition is " + (a + b));
                            break;
                        case 2:
                            Console.WriteLine("The substraction is " + (a - b));
                            break;
                        case 3:
                            Console.WriteLine("The multiplication is " + (a * b));
                            break;
                        case 4:
                            Console.WriteLine("The division is " + (a / b));
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;

                    }
                    Console.WriteLine("Do you want to continue ");
                    ch = Console.ReadLine()[0];
                } while (ch == 'y' || ch == 'Y');
            }
        }

        // menudriven of calculate area of circle rectangle triangle and square
        class menudriven1
        {
            static void Main(string[] args)
            {
                char ch;
                do
                {

                    Console.WriteLine("1.Area of circle \n 2.Area of rectangle \n 3.Area of triangle \n 4.Area of square");
                    Console.WriteLine("Enter choice which operation you can perform:");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter the radius of circle:");
                            int rad = int.Parse(Console.ReadLine());
                            Console.WriteLine("The area of circle is  " + (3.14 * rad * rad));
                            break;
                        case 2:
                            Console.WriteLine("Enter the length and width of rectangle:");
                            int len = int.Parse(Console.ReadLine());
                            int wdth = int.Parse(Console.ReadLine());
                            Console.WriteLine("The area of rectangle is  " + (len * wdth));
                            break;
                        case 3:
                            Console.WriteLine("Enter the base and height of triangle:");
                            int b = int.Parse(Console.ReadLine());
                            int h = int.Parse(Console.ReadLine());
                            Console.WriteLine("The area of triangle is  " + (0.5 * b * h));
                            break;
                        case 4:
                            Console.WriteLine("Enter the side of square:");
                            int side = int.Parse(Console.ReadLine());
                            Console.WriteLine("The area of square is  " + (side * side));
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;

                    }
                    Console.WriteLine("Do you want to continue ");
                    ch = Console.ReadLine()[0];
                } while (ch == 'y' || ch == 'Y');
            }
        }

        //sum the factorial of upto 5 factorial

        class factorial2
        {
            static void Main(string[] args)
            {
                int sum = 0, fact;
                for (int i = 1; i <= 5; i++)
                {
                    fact = 1;
                    for (int j = 1; j <= i; j++)
                    {
                        fact *= j;
                    }
                    sum += fact;
                }

                Console.WriteLine("The sum is " + sum);
            }
        }

        //tables between 1 to 5

        class table1to5
        {
            static void Main(string[] args)
            {

                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("The table of " + i);
                    for (int j = 1; j <= 10; j++)
                    {
                        Console.WriteLine(i * j);
                    }

                }


            }
        }
    }
}
