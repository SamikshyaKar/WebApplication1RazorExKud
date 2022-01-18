using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webapplication1RazorExKud.Models;

namespace Webapplication1RazorExKud.Services
{
    public class MockEmpRepo : IEmployeeRepository
    {
        private List<Employee> employeeList;

        public MockEmpRepo()
        {
            employeeList = new List<Employee>()
            {
                new Employee{ID=1, Name= "Samu", Department=Dept.IT,Photopath="Flower1.jpg",Email="aa@gmail.com" },
                new Employee{ID=2, Name= "Ramu", Department=Dept.HR,Email="bb@gmail.com"}
            };
        }
        public IEnumerable<Employee> GetallEmployees()
        {
            return employeeList;
        }

        public Employee GetGemployeebyID(int ID)
        {
            return employeeList.FirstOrDefault(e => e.ID == ID);
        }

        public Employee Update(Employee updatedEmployee)
        {
            Employee employee = employeeList
                .FirstOrDefault(e => e.ID == updatedEmployee.ID);
            if (employee != null)
            {
                employee.Name = updatedEmployee.Name;
                employee.Email = updatedEmployee.Email;
                employee.Department = updatedEmployee.Department;
            }
            return employee;
        }
    }
}
