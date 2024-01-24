using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructor.With_Primary_Constructor
{
    internal class Employee(string firstName, string lastName)
    {
        public string FullName()
        {
            return $"Full name  = {firstName} {lastName}";
        }
    }
}
