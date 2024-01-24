using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructor.How_to_paas_parameter_to_parent_class.if_child_class_has_primary_constructor
{
    internal class Parent_Class(string name)
    {
        
    }


    internal class Child_Class(string firstName, string lastName) : Parent_Class(firstName)
    {
    }

}
