using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
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
            {
                return courseCode;
            }
            set
            {
                courseCode = value;
            }
        }
        public int CourseCredit
        {
            get
            {
                return courseCredit;
            }
            set
            {
                courseCredit = value;
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
        static void Main(string[] args)
        {

            Course c = new Course();
            c.CourseName = "OOP2";
            c.CourseCredit = 3;
            c.CourseCode = "3115";
            c.ShowCourseInfo();
        }
    }
}
