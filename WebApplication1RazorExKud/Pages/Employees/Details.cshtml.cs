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
    public class DetailsModel : PageModel
    {
        private readonly IEmployeeRepository _empDetailskrepo;

        public DetailsModel(IEmployeeRepository employeeRepository)
        {
            this._empDetailskrepo = employeeRepository;
        }

        public Employee EmpDetailsProp { get; private set; }

        public IActionResult OnGet( int id)
        {
           EmpDetailsProp=  _empDetailskrepo.GetGemployeebyID(id);

            if(EmpDetailsProp ==null)
            {
                return RedirectToPage("/EmployeeNotFound");
            }

            return Page();
        }
    }
}
