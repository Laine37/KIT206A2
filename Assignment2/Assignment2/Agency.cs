using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut5
{
    abstract class Agency
    {
        public static List<Employee> Generate()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee { Name = "Jane", Id = 1, Gen = Employee.Gender.F },
                new Employee { Name = "John", Id = 2, Gen = Employee.Gender.M },
                new Employee { Name = "Billy", Id = 3, Gen = Employee.Gender.M },
                new Employee { Name = "Anona", Id = 4, Gen = Employee.Gender.X },
                new Employee { Name = "Liv", Id = 5, Gen = Employee.Gender.F }
            };

            return employees;
        }
    }
}
