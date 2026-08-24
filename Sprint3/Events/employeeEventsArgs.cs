using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
  public void AddtoActiveEmployee()
{
    if (Onboarding.Count == 0)
    {
        Console.WriteLine("No employee onboarding");
        return;
    }

    Employee e1 = Onboarding.Dequeue();
    ActiveEmployee.Add(e1);
    ActionHistory.Push($"{e1.Name} removed from Onboarding && added to Active Employee");

    EmployeeOnboarded?.Invoke(this, new EmployeeEventArgs(e1));   ا
}
}
