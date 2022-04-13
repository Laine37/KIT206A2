using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut5
{
    public delegate Employee ManageWorker(int id);
    class Program
    {
        static List<Employee> filterByGender(List<Employee> staff, Employee.Gender gender)
        {
            IEnumerable<Employee> filteredEmployees =
                from employee in staff
                where employee.Gen == gender
                select employee;
            return filteredEmployees.ToList();
        }

        /*static void addEmployees()
        {
            Employee emp1 = new Employee { name = "Jane", id = 1, gen = Employee.Gender.F };
            Employee emp2 = new Employee { name = "John", id = 2, gen = Employee.Gender.M };
            Employee emp3 = new Employee { name = "Billy", id = 3, gen = Employee.Gender.M };
            Employee emp4 = new Employee { name = "Anona", id = 4, gen = Employee.Gender.X };
            Employee emp5 = new Employee { name = "Liv", id = 5, gen = Employee.Gender.F };

            List<Employee> employees = new List<Employee>();

            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);
            employees.Add(emp5);

            foreach (Employee item in filterByGender(employees, Employee.Gender.X))
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }*/

        static void Main(string[] args)
        {
            List<TrainingSession> trainingSessions = new List<TrainingSession>();

            /*trainingSessions.Add(new TrainingSession("One", 2004, DateTime.Now.AddDays(-1557), Mode.Conference));
            trainingSessions.Add(new TrainingSession("Two", 2007, DateTime.Now.AddDays(-974), Mode.Journal));
            trainingSessions.Add(new TrainingSession("Three", 1994, DateTime.Now.AddDays(-2375), Mode.Conference));
            trainingSessions.Add(new TrainingSession("Four", 2015, DateTime.Now.AddDays(-156), Mode.Other));
            trainingSessions.Add(new TrainingSession("Five", 2018, DateTime.Now.AddDays(-26), Mode.Conference));*/

            IEnumerable<TrainingSession> filteredTrainingSessions =
                from trainingSession in trainingSessions
                where trainingSession.Freshness < 201
                select trainingSession;

            Action display;

            Boss boss = new Boss();

            display = boss.Display;

            /*ManageWorker use;

            //addEmployees();

            use = boss.Use;

            display();

            Console.WriteLine("\n" + use(1) + "\n");

            display();

            Console.WriteLine("\n" + boss.Fire(1) + "\n");

            display();*/

            display();

            foreach (TrainingSession trainingSession in filteredTrainingSessions)
            {
                Console.WriteLine(trainingSession.ToString());
            }

            foreach (TrainingSession session in Agency.LoadTrainingSessions(123460))
            {
                Console.WriteLine(session.ToString());
            }

            Console.ReadLine();
        }
    }
}
