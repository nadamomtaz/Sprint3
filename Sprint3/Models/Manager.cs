using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    internal class Manager:Employee
    {
        public Manager(int Id, string name,  int departmentId, decimal salary)
    : base( Id ,name , departmentId,salary)
        {
          
        }
        List<Employee>TeamMember=new List<Employee>();
    }
}
