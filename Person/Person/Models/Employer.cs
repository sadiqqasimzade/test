using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Models
{
    class Employer:Person
    {
        double SalaryHour { get; set; }
        int WorkingHour { get; set; }

        public Employer(string name,string surname,int age,double salaryhour,int workinghour)
        {
            Name = name;
            Surname = surname;
            Age = age;
            SalaryHour = salaryhour;
            WorkingHour = workinghour;
        }

        public double CalculateSalary()
        {
            return SalaryHour * WorkingHour;
        }

        public void AgeChecker()
        {

        }
    }
}
