using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructor.Multiple_Constructor
{
    class Employee(string firstName, string lastName)
    {
        public Employee()
        {

        }


        public Employee(string firstName, string lastName, int salary)
        {

        }

        public string FullName()
        {
            return $"Full name  = {firstName} {lastName}";
        }
    }
}
