using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static void Main(string[] args)
        {




            Console.WriteLine("Enter The price on without tax of one kilogram of potatos");

            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  The kilograms you wanna buy");

            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter  The Tax in percent of  units ");

            int tax = Convert.ToInt32(Console.ReadLine());
            int total = price * number + price * number * tax / 100;
            Console.WriteLine(" Total Price including Tax ");
            Console.WriteLine(total);

        }
    }
}
