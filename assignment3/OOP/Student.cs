using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.OOP
{
    public class Student : Person, IStudentService
    {
        private int id;
        public int Id
        {
            get { return id; }
            private set { id = value; }
        }
        public int totalCourse { get; set; }
        private string _University;
        public string University
        {
            get { return _University; }
            private set { _University = value; }
        }
        private string major;
        public string Major
        {
            get { return major; }
            private set { major = value; } 
        }

        public string[] courses(int numCourses)
        {
            string[] courses = new string[numCourses];
            for (int i = 0; i < courses.Length; i++)
            {
                Console.Write("enter coursename: ");
                courses[i] = Console.ReadLine();
            }
            return courses;

        }

        public float gpa(float[] grade)
        {
            float gpa = 0;
            for(int i = 0; i < grade.Length; i++)
            {
                gpa += grade[i];
            }
            gpa = gpa / grade.Length * 4;
            return gpa;
        }

        public string letterGrade(float gpa)
        {
            if (gpa == 4.0)
            {
                return "A";
            } else if (gpa > 3.3)
            {
                return "B";
            } else if (gpa > 2.0)
            {
                return "C";
            } else
            {
                return "D";
            }
        }
    }
}
