using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OopDemo.AbstractDemo;
using OopDemo.InterfacesDemo;

namespace OopDemo
{
    // pag.56, static methods

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("// --- Constructor test --- //");
            NormalMember normalMember = new NormalMember();
            Console.WriteLine();
            NormalMember secondNormalMember = new NormalMember("a", "nameNormal", 1, 2010);
            secondNormalMember.updateAnnualFee();
            Console.WriteLine("\nToString method: " + secondNormalMember.ToString() + "\n");

            VIPMember vipMember = new VIPMember("b", "nameVip", 1, 2010);
            vipMember.updateAnnualFee();
            Console.WriteLine(vipMember.ToString() + "\n");

            // --- Polymorphism test --- //
            //Polymorphism refers to a program’s ability to use the correct method for
            //an object based on its run - time type
            //PREFACE: THIS HAPPENS BECAUSE WE ARE USING AN INSTANCE OF THE PARENT CLASS
            Console.WriteLine("// --- Polymorphism --- //");
            List<Member> members = new List<Member>();
            members.Add(new NormalMember("welcome Johnny, new normal member", "Johnny Boy", 23, 2011));
            Console.WriteLine();
            members.Add(new VIPMember("thank you VIP", "Peter Snow", 1, 2010));
            foreach(var tmpMember in members)
            {
                //The following method must be declared in the child classes and in the parent one 
                //using the keyword "virtual"(parent class) and "override"(child classes)
                //C# is able to use the method of the right subclass at runtime
                //if the compiler doesn't find the implementation inside the child class it uses the parent class implementation 
                Console.WriteLine();
                tmpMember.printMemberQualification();
                Console.WriteLine(tmpMember.testVirtualInt + "\n");

                //GetType() and typeof()
                //if (tmpMember.GetType() == typeof(VIPMember))
                //    Console.WriteLine("VIP Member");
            }

            // --- ABSTRACT classes --- //
            //An abstract class is a special type of class that is created strictly to be a base class for other
            //classes to derive from.They cannot be instantiated.In other words, if FourWheelVehicles is an
            //abstract class, the statement
            //FourWheelVehicle myVeh = new FourWheelVehicle();
            //will give you an error as you cannot create an object of an abstract class
            //ONE CLASS CAN INHERIT ONE PARENT ABSTRACT CLASS
            Console.WriteLine("\n // --- AbstractClass --- //");
            InheritingAbstractClass inheritingAbstractClass = new InheritingAbstractClass();
            inheritingAbstractClass.printMessage();
            inheritingAbstractClass.printSecondMessage();
            Console.WriteLine();

            // --- INTERFACES --- //
            //Interfaces are much like abstract classes in that they cannot be
            //instantiated and must be inherited.However, interfaces are more conceptual than abstract
            //classes.They can only contain methods with no bodies.In addition, they cannot contain fields
            //but can contain properties. Interfaces also cannot have static members.When a child class
            //inherits an interface, we say that it implements the interface.
            //One of the key differences between an abstract class and an interface is that a class can only
            //inherit one abstract class but can implement multiple interfaces.
            Console.WriteLine("\n // --- Interface --- //");
            ImplementingInterface implementigInterface = new ImplementingInterface();
            implementigInterface.message = "Interface test !";
            implementigInterface.printInterfaceMessage();

            Console.WriteLine("\n\n");

            Animal animal = new Animal();
            animal.nameProp = "lion";
            animal.heigthProp = 1.65f;
            animal.idProp = "1";
            Console.WriteLine(animal.showContinentAndName());

            Animal secondAnimal = new Animal("zebra", 1.78f, "2");
            Console.WriteLine(secondAnimal.ToString());

            Animal.staticField = "Static field has been set";
            Console.WriteLine(Animal.staticField);

            StaticClass.field = "xxx";
            Console.WriteLine(StaticClass.field);
        }
    }

    // --- Class definition --- //
    public class Animal
    {
        private const string continent = "Africa";
        // if we don't specify condition for get and set we use the following notation
        public string idProp { get; set; }
        public string nameProp { get; set; }
        private float heigth;

        // --- properties definition --- //
        public float heigthProp // the same type of his 
        {
            get
            {
                return this.heigth;
            }

            set
            {
                // "value" is the value passed for setting
                if (value <= 0)
                    this.heigth = 1.20f;
                else
                    this.heigth = value;
            }
        }

        // --- static field --- //
        public static string staticField = "Static field content";


        // --- constructors section --- //
        public Animal()
        {

        }

        public Animal(string name_, float heigth_, string id_)
        {
            this.nameProp = name_;
            this.heigth = heigth_; // OR this.heigthProp = height;
            this.idProp = id_; // OR this.idProp
        }


        // --- methods section --- //
        // --- Overloading: the same method with the same return type and name but different parameters
        public string showContinentAndName()
        {
            return continent + " " + this.nameProp;
        }

        public string showContinentAndName(bool testBool)
        {
            return continent + " " + this.nameProp;
        }

        // --- "override" means that a special methods is customized, same return type name and parameters --- //
        public override string ToString()
        {
            return "Continent " + continent + " - Name " + this.nameProp + " - Id " + this.idProp + " - Heigth " + this.heigth;
        }

        // --- static method --- //
        public static void staticMethod()
        {
            Console.WriteLine("Static method executed !");
        }
    }

    // --- Static class --- //
    public static class StaticClass
    {
        // All the members are static --- //
        public static string field = "Static field";
        public static string secondField { get; set; }

        public static void staticMethod()
        {
            Console.WriteLine("Static method executed !");
        }
    }
}
