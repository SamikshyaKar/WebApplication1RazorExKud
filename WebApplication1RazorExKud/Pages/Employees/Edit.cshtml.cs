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
        private readonly IEmployeeRepository Editemprepo;

        public EditModel(IEmployeeRepository employeeRepository)
        {
            this.Editemprepo = employeeRepository;
        }

        public Employee EmpEditProp { get; set; }
        public IActionResult OnGet(int id)
        {
            EmpEditProp = Editemprepo.GetGemployeebyID(id);
            if (EmpEditProp == null)
            {
                return RedirectToPage("/EmployeeNotFound");
            }

            return Page();
        }
    }
}
