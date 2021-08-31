using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dictionary 

            Dictionary<int, string> ndictionary = new Dictionary<int, string>();
            ndictionary.Add(1, "noman");
            ndictionary.Add(2, "raju");
            ndictionary.Add(3, "iqbal");
            ndictionary.Add(4, "plabon");
            string outPut;
            if(ndictionary.TryGetValue(3,out outPut))
            {

                Console.WriteLine("find Data:" + outPut);
            }
            else
            {

                Console.WriteLine("data not found");

            }

            foreach(var data in ndictionary)
            {

                Console.WriteLine("Key:"+ data.Key + "Value:"+ data.Value);

            }











            /*
            //Queue

            Queue<int> nQueue = new Queue<int>();
            nQueue.Enqueue(12);
            nQueue.Enqueue(13);
            nQueue.Enqueue(14);
            nQueue.Enqueue(15);
            nQueue.Enqueue(16);
            nQueue.Enqueue(17);
            nQueue.Enqueue(18);



            foreach (var data in nQueue)
            {

                Console.WriteLine(data);

            }

            nQueue.Dequeue();
            nQueue.Dequeue();

            Console.WriteLine("After Dequee");
            foreach (var data in nQueue)
            {

                Console.WriteLine(data);

            }
            */

            /*
            //stack
            Stack<int> aStack = new Stack<int>();
            aStack.Push(1);
            aStack.Push(2);
            aStack.Push(3);
            aStack.Push(4);
            aStack.Push(5);
            foreach (var data in aStack)
            {


                Console.WriteLine(data);

            }

            aStack.Pop();
            aStack.Pop();

            Console.WriteLine("After Pop ");
            foreach (var data in aStack)
            {


                Console.WriteLine(data);

            }*/


            Console.ReadKey();

        }
    }
}
