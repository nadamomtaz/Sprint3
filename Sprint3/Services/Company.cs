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
        public event Eventhandler<EmployeeEventArgs> EmployeeOnboarded;
        public Result<Employee> AddEmployee(Employee employee)
                        {
                            Onboarding.Enqueue(employee);
                            ActionHistory.Push($"{employee.Name} added to Onboarding");
                        
                            return new Result<Employee>
                            {
                                Success = true,
                                Message = $"{employee.Name} added to onboarding queue.",
                                Data = employee
                            };
                        }
        public void AddtoActiveEmployee()
        {
            if (Onboarding.Count == 0)
            {
                Console.WriteLine(" No employee onboarding");
                return;
            }

            Employee e1 = Onboarding.Dequeue();
            ActiveEmployee.Add(e1);
            ActionHistory.Push($"{e1.Name} removed from Onboarding && added to Active Employee");

        }
public Result<Department> AddNewDepartment(Department department)
{
    if (Departments.ContainsKey(department.Id))
    {
        return new Result<Department>
        {
            Success = false,
            Message = $"Department with Id {department.Id} already exists.",
            Data = null
        };
    }

    Departments.Add(department.Id, department);
    ActionHistory.Push($"{department.Name} added to Departments");

    return new Result<Department>
    {
        Success = true,
        Message = $"{department.Name} added",
        Data = department
    };
}
        public void AddEmployeeSkills(string skill, Employee employee)
        {
            employee.skills.Add(skill);
            skilles.Add(skill);
            ActionHistory.Push($" {skill} added to{employee.Name}");
        }
         public void AddEmployeSkills(string skill, Employee employee)
        {
            employee.skills.Add(skill);
            skilles.Add(skill);
            ActionHistory.Push($" {skill} added to{employee.Name}");
        }
        
        
    }
    
}
