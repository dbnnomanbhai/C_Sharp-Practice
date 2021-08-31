using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifer

{
    class Student
    {
        private String name;
        private int  id;
        private String department;
        private float cgpa;
        private string major;


        public string Name
        {
            get
            { return name; }
            set
            { name = value; }
        }
        public int Id
        {
            get
            { return id; }
            set
            { id = value; }
        }
        public string Department
        {
            get
            { return department; }
            set
            { department = value; }
        }
        public float Cgpa
        {
            get
            { return cgpa; }
            set
            { cgpa = value; }
        }

        public string Major
        {
            get
            { return major; }
            set
            { major = value; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Student name :" + name);
            Console.WriteLine("Student ID :" + id);
            Console.WriteLine("Student Department :" + department);
            Console.WriteLine("Students Cgpa" + cgpa);
            Console.WriteLine("Students Major declaration" + major);

        }


    }

    
    
    class Course
    {
        private String courseName;
        private int  courseCode;
        
        private int courseCredit;
        private String courseTeacher;



        public String CourseName
        {
            get
            { return courseName; }
            set
            { courseName = value; }
        }
        public int  CourseCode
        {
            get
            { return courseCode; }
            set
            { courseCode = value; }
        }
        public int CourseCredit
        {
            get
            { return courseCredit; }
            set
            { courseCredit = value; }
        }

        public String CourseTeacher
        {
            get
            { return courseTeacher; }
            set
            { courseTeacher = value; }
        }


        public void ShowCourseInfo()
        {
            Console.WriteLine("Course name   : " + courseName);
            Console.WriteLine("Course code   : " + courseCode);
            Console.WriteLine("Course credit : " + courseCredit);
            Console.WriteLine("Course credit : " + courseTeacher);

        }

    }
    class Program
    {
        static void Main(String[] args)
        {
            Course a = new Course();
            a.CourseName = "english";
            a.CourseCredit = 3;
            a.CourseCode = 3715;
            a.CourseTeacher = "Noman sir";

            a.ShowCourseInfo();




            Student s = new Student();
            s.Name = "Noman";
            s.Id = 18 - 38293 - 22;
            s.Department = "CSE";
            s.Cgpa = 3.54f;
            s.ShowInfo();
            Course n = new Course();
             




            Console.ReadKey();

        }
    }







}
