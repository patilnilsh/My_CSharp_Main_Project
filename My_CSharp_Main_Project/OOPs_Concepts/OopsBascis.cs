using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.OOPs_Concepts
{
    /*class OopsBascis
    { 
    
    }*/

        //method class  and create object
        class Employee
        {
            int empid;
            string name;
            int salary;

            public void emp()
            {
                empid = 111;
                name = "Aman";
                salary = 78000;
            }

            public void display()
            {
                Console.WriteLine(empid + " " + name + " " + salary);
            }
            static void Main(string[] args)
            {
                Employee e = new Employee();
                e.emp();
                e.display();
            }
        }

        class Car
        {
            int modelno;
            string carname;
            string carcolor;
            int prize;

            public void cardemo()
            {
                Console.WriteLine("Enter car model no: ");
                modelno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter car name: ");
                carname = Console.ReadLine();
                Console.WriteLine("Enter car color: ");
                carcolor = Console.ReadLine();
                Console.WriteLine("Enter car prize: ");
                prize = int.Parse(Console.ReadLine());
            }

            public void display1()
            {
                Console.WriteLine();
                Console.WriteLine("Model no:" + modelno);
                Console.WriteLine("Car name:" + carname);
                Console.WriteLine("Car color:" + carcolor);
                Console.WriteLine("Prize:" + prize);
            }
            static void Main(string[] args)
            {
                Car c = new Car();
                for (int i = 1; i <= 2; i++)
                {
                    c.cardemo();
                    c.display1();
                    Console.WriteLine();
                }
            }
        }

        class Student
        {
            int studid;
            string studname;
            int english;
            int math;
            int science;
            float perc;

            public void studdemo()
            {
                Console.WriteLine("Enter student id: ");
                studid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter student name: ");
                studname = Console.ReadLine();
                Console.WriteLine("Enter marks of English: ");
                english = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter marks of Math: ");
                math = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter marks of Science: ");
                science = int.Parse(Console.ReadLine());
            }
            public void percentage()
            {
                perc = ((english + math + science) / 3);
            }
            public void display()
            {
                Console.WriteLine();
                Console.WriteLine("Student ID:" + studid);
                Console.WriteLine("Student Name:" + studname);
                Console.WriteLine("English Marks:" + english);
                Console.WriteLine("Math Marks:" + math);
                Console.WriteLine("Science Marks:" + science);
                Console.WriteLine("Percentage:" + perc);
            }
            static void Main(string[] args)
            {
                Student s = new Student();
                s.studdemo();
                s.percentage();
                s.display();
                Console.WriteLine();

            }
        }

    }
