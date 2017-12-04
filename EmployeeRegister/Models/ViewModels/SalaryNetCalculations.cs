using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeRegister.Models.ViewModels
{
    public class SalaryNetCalculations
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Tax { get; set; }
        public int Salary { get; set; }
        public double NetPay { get; set; }

       
        public SalaryNetCalculations(Employee salary)
        {
            Id = salary.Id;
            FirstName = salary.FirstName;
            LastName = salary.LastName;
            Tax = 0.3;
            Salary = salary.Salary;
            NetPay = Salary - (Tax * Salary);

        }
    }
}

    