using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static void Main(string[] args)
        {

                
   
            Console.Write("Check whether a triangle can be formed by given value:\n");
         

            Console.Write("Input  First angel  of triangle: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input  second angle of triangle: ");
             int numb2  = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input angle 3 of triangle: ");
          int num3 = Convert.ToInt32(Console.ReadLine());


            int total = num1 + numb2 + num3;

            
            if (total == 180)
            {
                Console.Write("The triangle is valid .there has no problem.\n");
            }
            else
            {
                Console.Write("Sorry! The triangle is not valid.\n");
            }

        }
    }
}
