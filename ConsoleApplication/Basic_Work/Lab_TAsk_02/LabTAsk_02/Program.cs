using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {

              Console.WriteLine("Enter Your Marks : ");
            int Marks = Convert.ToInt32(Console.ReadLine());



            if (Marks >= 90 && Marks <= 100)
            {
                Console.WriteLine("your got  A+ ");
                Console.WriteLine("\n Congratulation ");
                Console.WriteLine("\nyour grade point is : 4 ");
            }




            else if (Marks >= 80 && Marks <= 89)
            {
                Console.WriteLine("your got  A ");
                Console.WriteLine("\n Congratulation ");
                Console.WriteLine("\nyour grade point is : 3.5 ");
            }



            else if (Marks >= 70 && Marks <= 79)
            {
                Console.WriteLine("your got  B+ ");
                Console.WriteLine("\n Congratulation ");
                Console.WriteLine("\nyour grade point is : 3 ");
            }
            else if (Marks >= 60 && Marks <= 69)
            {
                Console.WriteLine("your got  C ");
                Console.WriteLine("\n Congratulation ");
                Console.WriteLine("\nyour grade point is : 2.5 ");
            }
            else if (Marks >= 50 && Marks <= 59)
            {
                Console.WriteLine("your got  D ");
                Console.WriteLine("\n Congratulation ");
                Console.WriteLine("\nyour grade point is : 2 ");
            }
            else if (Marks >= 1 && Marks <= 49)
            {
                Console.WriteLine("your got  F ");
                Console.WriteLine("\n  Sorry! You Failed The Exam ");
                Console.WriteLine("\nyour grade point is : 0.0 ");
            }



            else if (Marks > 101)
            {
                Console.WriteLine("\nprogram error. Please enter a valid Marks  within 1-100) ");
            }
            else
            {
                Console.WriteLine("Enter a valid number");
            }






            Console.ReadKey();

        }
    }
}
