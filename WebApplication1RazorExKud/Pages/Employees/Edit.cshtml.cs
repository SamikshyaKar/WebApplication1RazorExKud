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
    public class EditModel : PageModel
    {
        private readonly IEmployeeRepository employeeRepository;

        public EditModel(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        // This is the property the display template will use to
        // display existing Employee data


        public Employee Employee { get; private set; }

        // Populate Employee property
        public IActionResult OnGet(int id)
        {
            Employee = employeeRepository.GetGemployeebyID(id);

            if (Employee == null)
            {
                return RedirectToPage("/EmployeeNotFound");
            }

            return Page();
        }

        public IActionResult OnPost(Employee employee)
        {
            Employee = employeeRepository.Update(employee);
            return RedirectToPage("Index");
        }
    }
}
