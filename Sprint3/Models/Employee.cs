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
        public List<string> skills new List<string>(); 
        
        //Id, Name, HireDate, DepartmentId, Salary
        public Employee(int id , string name , int DepartmentId,decimal salary) {
            this.Id = id;
            this.Name = name;
            this.DepartmentId = DepartmentId;
            this.Salary = salary;
            HireDate=DateTime.Now;
        }
    }
}
