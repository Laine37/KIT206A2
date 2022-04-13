using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Boss
    {
        private ObservableCollection<Employee> employees;

        public Boss()
        {
            employees = Agency.LoadAll();
        }

        public ObservableCollection<Employee> GetViewableList()
        {
            return employees;
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
