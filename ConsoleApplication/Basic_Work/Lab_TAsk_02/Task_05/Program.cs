using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    class Program
    {
        static void Main(string[] args)
        {

            int num, product;
            Console.Write("Enter the Number to Print its Multiplication Table: ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMultiplication Table For {0}: ", num);

            for (int i = 1; i <= 10; i++)
            {
                product = num * i;
                Console.WriteLine("{0} x {1} = {2}", num, i, product);
            }


            Console.ReadKey();
        }

    }
}

