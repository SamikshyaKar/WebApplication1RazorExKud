using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Webapplication1RazorExKud.Models;
using Webapplication1RazorExKud.Services;

namespace WebApplication1RazorExKud.Pages.Employees
{
    public class IndexModel : PageModel
    {
        private readonly IEmployeeRepository _empro;

        public IEnumerable<Employee> EmpProp { get; set; }
        public IndexModel(IEmployeeRepository employeeRepository)
        {
            this._empro = employeeRepository;
        }
        public void OnGet()
        {
            EmpProp = _empro.GetallEmployees();
        }
    }
}
