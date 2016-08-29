using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayBatch.Models
{
    class Employee
    {
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public DateTime? Birthdate { get; set; }


        public Employee()
        {
            this.Firstname = String.Empty;
            this.Lastname = String.Empty;
            this.Birthdate = null;
        }

        public Employee(String firstname, String lastname, DateTime birthdate)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Birthdate = birthdate;
        }
    }
}
