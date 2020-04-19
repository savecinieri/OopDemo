using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo.AbstractDemo
{
    abstract class AbstractClass
    {
        //Abstract classes may have fields, properties and methods just like any other classes.However,
        //they cannot have static members.In addition, abstract classes can have a special type of
        //method known as abstract methods.Abstract methods are methods that have no body and
        //MUST be implemented in the derived class. They can only exist in abstract classes.In a way,
        //an abstract method is like a contract.If you want to ensure that any class that inherits your
        //class implements a certain method, you can declare the class as an abstract class and the
        //method as an abstract method.
        //NO STATIC members

        protected string message = "Abstract class test !";
        private string secondMessage = "This is the second message inside the abstract class!";

        public abstract void printMessage();
        public void printSecondMessage() { Console.WriteLine( this.secondMessage); }
    }
}
