using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint3
{
    internal class Company
    {
        List<Employee> ActiveEmployee = new List<Employee>();
        Dictionary<int, Department> Departments = new Dictionary<int, Department>();
        Queue<Employee> Onboarding = new Queue<Employee>();
        Stack<string> ActionHistory = new Stack<string>();
        HashSet<string> skills = new HashSet<string>();
    }
}
