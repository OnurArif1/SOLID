using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingleResponsibility
{
    public class Employee
    {
        public int EmployeID { get; set; }
        public string EmployeName { get; set; }
        public bool InsertIntoEmployeeTable(Employee em)
        {
            return true;
        }
    }
}
