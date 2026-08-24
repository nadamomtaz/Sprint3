using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    internal class EmployeeEventArgs : EventArgs
    {
        public Employee Employee { get; }

        public EmployeeEventArgs(Employee employee)
        {
            Employee = employee;
        }
    }
}
