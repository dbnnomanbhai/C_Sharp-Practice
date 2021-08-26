using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array

{
    class Array
    {
         

            static void Main(string[] args)
            {
                
                 
                Console.Write("Enterv size of an  array: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[size];
             
                Console.WriteLine("Enter {0} elements in the array", size);
                for (int i = 0; i < size; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }

                
                Console.Write("\nElements in array are : ");
                for (int i = 0; i < size; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
                Console.ReadLine();
            }

        }




}

