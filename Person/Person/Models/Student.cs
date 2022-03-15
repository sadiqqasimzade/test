using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Models
{
    class Student : Person
    {
        public double MathPoint { get; set; }
        public double LanguagePoint { get; set; }

        public Student(string name, string surname, int age, double mathpoint, double languagepoint)
        {
            Name = name;
            Surname = surname;
            Age = age;
            MathPoint = mathpoint;
            LanguagePoint = languagepoint;
        }
        
        public void ExamResult()
        {

        }
    }
}
