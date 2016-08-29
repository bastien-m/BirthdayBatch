using BirthdayBatch.Models;
using BirthdayBatch.Provider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayBatch
{
    class Program
    {
        static List<Employee> GetUserBornThisDay(List<Employee> employees, DateTime dateToCompareWith)
        {
            return employees.FindAll(e => e.Birthdate.Equals(dateToCompareWith));
        }


        static void Main(string[] args)
        {

            CsvProvider csvProvider = new CsvProvider(@"AppData/Employees.csv");
            List<Employee> employees = csvProvider.GetEmployees();

            GetUserBornThisDay(employees, new DateTime(1990, 5, 4)).ForEach(e => Console.WriteLine(String.Format("Anniversaire de {0} {1}", e.Firstname, e.Lastname)));

            Console.WriteLine("Appuyez sur une touche pour quitter");
            Console.ReadLine();

        }
    }
}
