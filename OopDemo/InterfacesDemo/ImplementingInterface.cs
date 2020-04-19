using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo.InterfacesDemo
{
    class ImplementingInterface : InterfaceDemo
    {
        public string message { get; set; }

        //"override" keyword is not used, but is from a logical point of view an override 
        //infact return type name and parameters are the same
        public void printInterfaceMessage()
        {
            Console.WriteLine(this.message);
        }
    }
}
