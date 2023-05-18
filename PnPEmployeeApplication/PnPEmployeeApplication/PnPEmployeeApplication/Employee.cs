using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnPEmployeeApplication
{
    public class Employee:Person
    {
        private string empNum;

        public string EmpNum
        {
            get { return empNum; }
            set { empNum = value; }
        }

        public Employee(string perEmpNums,string  perName, string perSurname, DateTime perDob) :base(perName,perSurname,perDob)
        {
            this.EmpNum = perEmpNums;
        }

        public Employee()
        {

        }
    }
}
