using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructor.Multiple_Constructor
{
    class Employee1(string firstName, string lastName)
    {
        public Employee1() : this("", "")
        {

        }

        public Employee1(string firstName, string lastName, int salary) : this(firstName, lastName)
        {

        }

        public string FullName()
        {
            return $"Full name  = {firstName} {lastName}";
        }
    }
}
