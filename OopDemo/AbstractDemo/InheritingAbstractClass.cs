using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo.AbstractDemo
{
    class InheritingAbstractClass : AbstractClass
    {
        //protected string message = "Abstract class test !";
        //Inherited but not accessible -> private string secondMessage = "This is the second message inside the abstract class!";

        //public void printSecondMessage() { Console.WriteLine( this.secondMessage); }
        
        //Method defined abstract in the parent class
        public override void printMessage()
        {
            Console.WriteLine(this.message);
        }
    }
}
