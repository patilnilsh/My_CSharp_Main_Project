using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.OOPs_Concepts
{
   /* class UsasesOfTHIS
    {

    }*/
    

        //use of this keyword these are 3 uses of this keyword also use of constructor
        class Car1
        {
            int model_no;
            string name;
            string color;
            int prize;
            string cname;

            public void input(int model_no, string name, string color, int prize)
            {
                this.model_no = model_no;
                this.name = name;
                this.color = color;
                this.prize = prize;
            }

            void show()
            {
                this.input(102, "audi", "white", 3000000);
                Console.WriteLine(model_no);
                Console.WriteLine(name);
                Console.WriteLine(color);
                Console.WriteLine(prize);
            }

            public Car1(string cname)
            {
                this.cname = cname;
                display();
            }

            public void display()
            {
                Console.WriteLine(cname);
            }

            public Car1() : this("Breszza")
            {
                Console.WriteLine("I am the default constructor.");
            }
            static void Main(string[] args)
            {
                Car1 c1 = new Car1();

                c1.show();
            }
        }

        class Bank
        {
            int accno;
            string acctype;
            string custname;
            int balance;

            public void input()
            {
                Console.WriteLine("Enter account number:");
                accno = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter account type:");
                acctype = Console.ReadLine();
                Console.WriteLine("Enter customer name:");
                custname = Console.ReadLine();
                Console.WriteLine("Enter account balance:");
                balance = int.Parse(Console.ReadLine());
            }

            public void show()
            {
                Console.WriteLine();
                Console.WriteLine("Account number:" + accno);
                Console.WriteLine("Account type:" + acctype);
                Console.WriteLine("Customer name:" + custname);
                Console.WriteLine("Balance:" + balance);
            }

            public void withdrow()
            {
                Console.WriteLine("Enter amount you can withdrow:");
                int w = int.Parse(Console.ReadLine());
                balance = balance - w;
                display();
            }

            public void deposit()
            {
                Console.WriteLine("Enter amount you can deposit:");
                int d = int.Parse(Console.ReadLine());
                balance = balance + d;
                display();
            }

            public void display()
            {
                Console.WriteLine("The updated available balance is " + balance);
            }

            static void Main(string[] args)
            {
                Bank b = new Bank();
                b.input();
                b.show();
                Console.WriteLine("Which operation you can perform w or d:");
                int op = char.Parse(Console.ReadLine());
                if (op == 'w')
                    b.withdrow();
                else if (op == 'd')
                    b.deposit();
                else
                    Console.WriteLine("You entered wrong choice");
            }
        }


        class StudentDetails
        {
            int id;
            string name;
            int marks;

            public void student()
            {
                Console.WriteLine();
                Console.WriteLine("Enter student ID: ");
                id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter student name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter student marks: ");
                marks = int.Parse(Console.ReadLine());
            }

            public void display1()
            {
                Console.WriteLine();
                Console.WriteLine("Student Id:" + id);
                Console.WriteLine("Student name:" + name);
                Console.WriteLine("Student Marks:" + marks);
            }
            static void Main(string[] args)
            {
                StudentDetails s = new StudentDetails();
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("----------------Enter " + i + " student details-------------");
                    s.student();

                    Console.WriteLine("----------------Student " + i + " Details-------------------");
                    s.display1();
                    Console.WriteLine();
                }
            }
        }

    }

