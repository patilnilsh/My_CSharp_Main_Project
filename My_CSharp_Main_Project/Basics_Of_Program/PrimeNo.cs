using System;
using System.Collections.Generic;
using System.Text;

namespace My_CSharp_Main_Project.Basics_Of_Program
{
    class PrimeNo
    {
        static void Main(string[] args)
        {
            bool istrue;
            int i, j;
            Console.WriteLine("The prime numbers beetween 1 to 10 are:");
            for (i = 1; i <= 50; i++)
            {
                istrue = true;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        istrue = false;
                        break;

                    }
                }
                if (istrue == true)
                    Console.WriteLine(i);


            }
        }
    }

}
