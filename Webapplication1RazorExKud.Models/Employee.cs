using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webapplication1RazorExKud.Models
{
   public  class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Photopath { get; set; }
        public Dept? Department { get; set; }




    }
}
