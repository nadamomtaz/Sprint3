using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
  Company company = new Company();

  company.EmployeeOnboarded += (sender, args) =>
  {
      Console.WriteLine($"{args.Employee.Name} active employee");
  };
}
