using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{

    class Triangle
    {
        private int x;
        private int y;
        private int z;
        public int X
        {
            get
            { 
                return x;
            }
            set
            { 
                x = value; 
            }
        }
        public int Y
        {
            get
            {
                return y; 
            }
            set
            {
                y = value;
            }
        }
        public int Z
        {
            get
            {
                return z;
            }
            set
            { 
                z = value; 
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Value of X :" + x);
            Console.WriteLine("Value of y:" + y);
            Console.WriteLine("Value of z :" + z);
        }

        public void TestTriangle()
        {
            if (x == y && y == z)
            {
                Console.WriteLine("The triangle is an  Equilateral");

            }
            else if (x == y || x == z || y == z)
            {
                Console.WriteLine("This is an Isosceles triangle");
            }
            else
            {
                Console.WriteLine("This is a Scalene triangle");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Triangle t = new Triangle();
                t.X = 4;
                t.Y = 4;
                t.Z = 3;
                t.TestTriangle();


            }
        }
    }
}

