using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.OOP
{
    interface IStudentService
    {
        public string[] courses(int numCourses);
        public float gpa(float[] grade);
    }
}
