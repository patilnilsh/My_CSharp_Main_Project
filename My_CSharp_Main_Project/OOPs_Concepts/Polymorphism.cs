using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.OOPs_Concepts
{
    /*class Polymorphism
    {
    }*/


    //Polymorphisn 1.Compile time polymorphism
    //Method Overloading.

    class ShowDetails
    {
        void Show()
        {
            Console.WriteLine("Show method");
        }

        void Show(int a, int b)
        {
            Console.WriteLine(a + " " + b);
        }

        void Show(int a, float b)
        {
            Console.WriteLine(a + " " + b);
        }

        void Show(int a, int b, int c)
        {
            Console.WriteLine(a + " " + b + " " + c);
        }
        static void Main(string[] args)
        {
            ShowDetails s = new ShowDetails();
            s.Show();
            s.Show(4, 5);
            s.Show(4, 2.5f);
            s.Show(4, 5, 6);
        }
    }

    //Overloading for calculate arrithmetic operations

    class Arrithmetic
    {

        void calculate(int a, int b, int c)
        {

            Console.WriteLine("Addition is:" + (a + b + c));
        }

        void calculate(int a, int b)
        {

            Console.WriteLine("Substraction is:" + (a - b));
        }

        void calculate(int a, double b)
        {

            Console.WriteLine("Multiplication is:" + (a * b));
        }

        void calculate(double a, int b)
        {

            Console.WriteLine("Division is:" + (a / b));
        }

        static void Main(string[] args)
        {
            Arrithmetic a = new Arrithmetic();
            a.calculate(1, 2, 3);
            a.calculate(2, 1);
            a.calculate(5, 5);
            a.calculate(50, 5);
        }
    }

    //Overloading for calculate area of circle,rectangle,triangle,square.

    class Areas
    {

        void area(float r)
        {

            Console.WriteLine("Area of circle is:" + (3.14 * r * r));
        }

        void area(int a, int b)
        {

            Console.WriteLine("Area of rectangle is:" + (a * b));
        }

        void area(int b, float h)
        {

            Console.WriteLine("Area of triangle is:" + (0.5 * b * h));
        }

        void area(int s)
        {

            Console.WriteLine("Area of square is:" + (s * s));
        }

        static void Main(string[] args)
        {
            Areas a = new Areas();
            Console.WriteLine("Enter radius for calculate area of circle:");
            float r = float.Parse(Console.ReadLine());
            a.area(r);

            Console.WriteLine("Enter length and width for calculate area of rectangle:");
            int ab = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            a.area(ab, b);

            Console.WriteLine("Enter base and height for calculate area of triangle:");
            int x = int.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            a.area(x, y);

            Console.WriteLine("Enter side for calculate area of square:");
            int z = int.Parse(Console.ReadLine());
            a.area(z);
        }
    }

    //constructor Overloading for calculate area of circle,rectangle,triangle,square.

    class Areas1
    {

        public Areas1(float r) : this(4f, 5f)
        {

            Console.WriteLine("Area of circle is:" + (3.14 * r * r));
        }

        public Areas1(float a, float b) : this(6, 5f)
        {

            Console.WriteLine("Area of rectangle is:" + (a * b));
        }

        public Areas1(int b, float h) : this(6)
        {

            Console.WriteLine("Area of triangle is:" + (0.5 * b * h));
        }

        public Areas1(int a)
        {

            Console.WriteLine("Area of square is:" + (a * a));
        }


        static void Main(string[] args)
        {
            Areas1 a = new Areas1(3f);

        }
    }
}



