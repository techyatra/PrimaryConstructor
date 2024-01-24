using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimaryConstructor.How_to_paas_parameter_to_parent_class.if_child_class_does_not_have_primary_constructor
{
    internal class Parent_Class
    {
        public Parent_Class(string s)
        {
                
        }
    }



    internal class Child_Class: Parent_Class
    {
        public Child_Class(string s): base(s)
        {
                
        }
    }
}
