using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructor.Without_Primary_Constructor
{
    internal class Employee
    {
        private readonly string firstName;
        private readonly string lastName;

        public Employee(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public string FullName()
        {
            return $"Full name  = {this.firstName} {this.lastName}";
        }
    }
}
