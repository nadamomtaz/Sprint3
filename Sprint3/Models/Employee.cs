using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int DepartmentId { get; set; }
        public DateTime HireDate{ get; set; }
        public decimal Salary { get; set; }
        
        //Id, Name, HireDate, DepartmentId, Salary
    }
}
