using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsitionalStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter  english score");
            string english = Console.ReadLine();
            int engscore = Convert.ToInt32(english);
            string result = "";

           

            if (engscore >= 50)
            {
                //Console.WriteLine("you passed the exm");
                result = "congratulation";


            }
            else
            {
                result = "sorry you failed";
                // Console.WriteLine("you Failedxm");

            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
