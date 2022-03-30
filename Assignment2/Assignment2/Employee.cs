using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut5
{
    public class Employee
    {
        private string name;
        private int id;
        private Gender gen;

        public enum Gender
        {
            M,
            F,
            X
        }

        public string Name { get { return name; } set { if (value != null) name = value; } }

        public int Id { get { return id; } set { id = value; } }

        public Gender Gen { get { return gen; } set { gen = value; } }

        public override string ToString()
        {
            return name + " " + id.ToString() + " " + gen.ToString();
        }
    }
}
