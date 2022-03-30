using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut5
{
    class Program
    {
        static List<Employee> filterByGender(List<Employee> staff, Employee.gender gender)
        {
            List<Employee> returnList = new List<Employee>();

            foreach (Employee item in staff)
            {
                if (item.gen == gender)
                {
                    returnList.Add(item);
                }
            }
            return returnList;
        }

        static void Main(string[] args)
        {
            Employee emp1 = new Employee { name = "Jane", id = 1, gen = Employee.gender.F };
            Employee emp2 = new Employee { name = "John", id = 2, gen = Employee.gender.M };
            Employee emp3 = new Employee { name = "Billy", id = 3, gen = Employee.gender.M };
            Employee emp4 = new Employee { name = "Anona", id = 4, gen = Employee.gender.X };
            Employee emp5 = new Employee { name = "Liv", id = 5, gen = Employee.gender.F };

            List<Employee> employees = new List<Employee>();

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);
            employees.Add(emp5);

            foreach (Employee item in filterByGender(employees, Employee.gender.X))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
