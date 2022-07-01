using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.OOP
{
    public class Department : IDepartment
    {
        private string headName;
        public string HeadName
        {
            get { return headName; }
            private set { headName = value; }
        }

        private DateTime start;
        private DateTime end;
        public DateTime Start
        {
            get { return start; }
            private set { start = value; }

        }
        public DateTime End
        {
            get { return end; }
            private set { end = value; }
        }

        public string[] courseList(int departmentId, int courseNum)
        {
            string[] courseList = new string[courseNum];
            for (int i = 0; i < courseNum; i++)
            {
                Console.Write("Enter Course Name: ");
                courseList[i] = Console.ReadLine();
            }
            return courseList;
        }
    }
}
