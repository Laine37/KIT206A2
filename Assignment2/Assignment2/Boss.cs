using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut5
{
    class Boss
    {
        private List<Employee> employees;

        public Boss()
        {
            employees = Agency.LoadAll();
        }

        public void Display()
        {
            foreach (Employee item in employees)
            {
                Console.WriteLine(item);
            }
        }

        public Employee Use(int id)
        {
            foreach (Employee item in employees)
            {
                if (item.Id == id)
                {
                    return item;
                }
            }

            return null;
        }

        public Employee Fire(int id)
        {
            foreach(Employee item in employees)
            {
                if (item.Id == id)
                {
                    Employee temp = item;
                    employees.Remove(item);
                    return temp;
                }
            }

            return null;
        }
    }
}
