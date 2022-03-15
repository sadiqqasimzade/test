using System;
using System.Collections.Generic;
using System.Text;

namespace Person.Models
{
    abstract class Person
    {
       public string Name { get; set; }
       public string Surname { get; set; }

        
       public int Age { get; set; }
    }
}
