using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tut5
{
    class Employee
    {
        public string name;
        public int id;
        public gender gen;

        public enum gender
        {
            M,
            F,
            X
        }

        public override string ToString()
        {
            return name + " " + id.ToString() + " " + gen.ToString();
        }


    }
}
