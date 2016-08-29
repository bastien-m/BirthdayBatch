using BirthdayBatch.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayBatch
{
    internal abstract class AbstractDataProvider
    {

        protected List<Employee> employees;
        public abstract List<Employee> GetEmployees();

    }
}
