using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3.OOP
{
    interface IPersonService
    {
        public int Age(int year);
        public decimal Salary(decimal hourlyPay);
        public string Address(string address);

    }
}
