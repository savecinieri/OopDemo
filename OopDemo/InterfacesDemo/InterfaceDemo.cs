using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo.InterfacesDemo
{
    interface InterfaceDemo
    {
        //All properties and methods in an interface
        //are public, so there is no need to add any access modifiers to them.

        //private string message = "";  NOT ALLOWED
        string message { get; set; }

        void printInterfaceMessage();
    }
}
