using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace  Task_01

{
    class Student
    {
        private String name;
        private String id;
        private String department;
        private float cgpa;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value; 
            }
        }
        public string Id
        {
            get
            { return id; }
            set
            {
                id = value;
            }
        }
        public string Department
        {
            get
            { 
                return department;
            }
            set
            { 
                department = value; 
            }
        }
        public float Cgpa
        {
            get
            { 
                return cgpa;
            }
            set
            { 
                cgpa = value; 
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("Student name :" + name);
            Console.WriteLine("Student ID :" + id);
            Console.WriteLine("Student Department :" + department);
            Console.WriteLine("Student Cgpa" + cgpa);

        }


    }

    class Triangle
    {
        private int x;
        private int y;
        private int z;
        public int X
        {
            get
            { return x; }
            set
            { x = value; }
        }
        public int Y
        {
            get
            { return y; }
            set
            { y = value; }
        }
        public int Z
        {
            get
            { return z; }
            set
            { z = value; }
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



    }
    class Account
    {
        private String accName;
        private String acid;
        private int balance;

        public String AccName
        {
            get
            { 
                return accName; 
            }
            set
            { 
                accName = value;
            }
        }
        public String Acid
        {
            get
            { 
                return acid; 
            }
            set
            { 
                acid = value; 
            }
        }

        public int Balance
        {
            get
            {
                return balance;
            }
            set
            { balance = value; }
        }
        public int Deposit(int amount)
        {
            if (amount > 0)
            {
                Console.WriteLine("Deposited Amount =" + amount);
            }
            else {
                Console.WriteLine("Sorry! Amount not Deposited ");
                Console.WriteLine(" Thank Your Staying Us");
            }
            return amount;

        }
        public int Withdraw(int amount)
        {
            if (amount <= balance)
            {
                Console.WriteLine("Amount  successfully withdrawed");
                Console.WriteLine(" Thank Your Staying Us");

            }
            else
            {
                Console.WriteLine("sorry! You do not have enough balance to withdraw");
                Console.WriteLine(" Thank Your Staying Us");
            }
            return amount;
        }
    }
    class Course
    {
        private String courseName;
        private String courseCode;
        private int courseCredit;
        public String CourseName
        {
            get
            { 
                return courseName; 
            }
            set
            { 
                courseName = value;
            }
        }
        public String CourseCode
        {
            get
            { return courseCode;
            }
            set
            { courseCode = value; 
            }
        }
        public int CourseCredit
        {
            get
            { return courseCredit;
            }
            set
            { courseCredit = value; 
            }
        }
        public void ShowCourseInfo()
        {
            Console.WriteLine("Course name   : " + courseName);
            Console.WriteLine("Course code   : " + courseCode);
            Console.WriteLine("Course credit : " + courseCredit);

        }

    }
    class Program
    {
        static void Main(String[] args)
        {
            Student std = new Student();
            std.Name = "Najmul Uddin ";
            std.Id = "18-38293-2";
            std.Department = "CSE";
            std.Cgpa = 3.55f;
            std.ShowInfo();


            Triangle t = new Triangle();
            t.X = 4;
            t.Y = 4;
            t.Z = 3;
            t.TestTriangle();


            Account acc = new Account();
            acc.AccName = "Najmul Uddin NOman";
            acc.Acid = "1838293";
            acc.Balance = 13000;
            acc.Deposit(1500);
            acc.Withdraw(500);



        }
    }




}
