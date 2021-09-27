using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
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



    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student();
            std.Name = "Najmul Uddin ";
            std.Id = "18-38293-2";
            std.Department = "CSE";
            std.Cgpa = 3.55f;
            std.ShowInfo();
        }
    }
}
