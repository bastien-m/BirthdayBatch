using BirthdayBatch.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayBatch.Provider
{
    class CsvProvider : AbstractDataProvider
    {
        private String filename;

        public CsvProvider(String filename)
        {
            this.filename = filename;
        }

        public override List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            foreach (String line in this.GetLinesFromCSV(this.filename))
            {
                employees.Add(BuildEmployeeFromCSVFile(line));
            }

            return employees;
        }

        private List<String> GetLinesFromCSV(String filename)
        {
            String appDataPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            String completePath = Path.Combine(appDataPath, filename);
            return File.ReadAllLines(completePath).ToList();
        }

        private Employee BuildEmployeeFromCSVFile(String csvLine)
        {
            Employee employee = new Employee();
            String[] lineSplit = csvLine.Split(';');

            employee.Firstname = lineSplit[0];
            employee.Lastname = lineSplit[1];
            employee.Birthdate = Utils.GetDateFromString(lineSplit[2]);

            this.employees = employees;


            return employee;
        }

    }
}
