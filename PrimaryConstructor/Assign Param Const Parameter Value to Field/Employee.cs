using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructor.Assign_Param_Const_Parameter_Value_to_Field
{
    internal class Employee(string firstName, string lastName)
    {
        private readonly string fName = firstName;
        private readonly string fstName = firstName.Length >= 5 ?
                                        firstName : throw new Exception("There must be atleast 5 characters");


        private readonly string lName = lastName;

        public void FullName()
        {
            string fullname  = firstName + " " + lastName;
            Console.WriteLine(fullname);
        }
    }
}
