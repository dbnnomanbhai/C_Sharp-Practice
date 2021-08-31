using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
          int result =  Add(3, 4);
            Console.WriteLine(result);
             
            int sumresult = Sub(5, 3);
            Console.WriteLine(sumresult);
            Console.ReadKey();

        }
        static int Add (int firstNum, int secondNum)
        {

            int sum = firstNum + secondNum;
            return sum;

        }
        static int Sub(int firstNum, int secondNum)
        {

            int sub = firstNum - secondNum;
            return sub;

        }




    }
}
