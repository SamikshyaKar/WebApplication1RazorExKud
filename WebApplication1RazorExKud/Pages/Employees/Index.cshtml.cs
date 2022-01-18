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
        private readonly IEmployeeRepository employeeRepository;


        public IEnumerable<Employee> Employees { get; set; }


        public IndexModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public void OnGet()
        {
            Employees = employeeRepository.GetallEmployees();
        }
    }
}