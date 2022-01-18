using System;
using System.Collections.Generic;
using Webapplication1RazorExKud.Models;

namespace Webapplication1RazorExKud.Services
{
    public interface IEmployeeRepository
    {

        IEnumerable<Employee> GetallEmployees();
        Employee GetGemployeebyID(int ID);

    }
}
