using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    internal class Manager:Employee
    {
        public Manager(int Id, string name,  int departmentId, decimal salary,DateTime HireDate)
    : base( Id ,name , departmentId,salary, HireDate)
        {
          
        }
      public List<Employee>TeamMembers=new List<Employee>();
    }
}
