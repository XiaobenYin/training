using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.OOP
{
    public class Instructor : Person, IInstructorService
    {
        public Instructor(int id, string name, string department)
        {
            Id = id;
            Name = name;
            Department = department;
        }

        public string Department { get; private set; }

        public decimal bonusSalary(DateTime joinDate)
        {
            DateTime currTime = DateTime.Now;
            TimeSpan totalBonus = currTime.Subtract(joinDate);
            decimal total = (decimal)totalBonus.TotalDays;
            return total;
        }

        public bool isHead(int year)
        {
            if (year > 20)
            {
                return true;
            }
            return false;
        }
    }
}
