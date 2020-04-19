using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo
{
    class VIPMember : Member
    {
        //protected int annualFee;
        //private fields inherited but not accessible here

        //public Member()
        //{
        //    Console.WriteLine("Parent Constructor with no parameter");
        //}
        public VIPMember()
        {
            // --- IMPORTANT --- //
            //The constructor of the Parent class "with no parameter" is called 
            // --- --- //

            Console.WriteLine("Child constructor with no parameter");
        }

        //public Member(string pName, int pMemberID, int pMemberSince)
        //{
        //    Console.WriteLine("Parent Constructor with 3 parameters");
        //    name = pName;
        //    memberID = pMemberID;
        //    memberSince = pMemberSince;
        //}
        public VIPMember(string param, string name, int id, int memberSince) : base(name, id, memberSince)
        {
            // --- IMPORTANT --- //
            //The constructor of the Parent class "with 3 parameter" is called 
            // We forced this behavior using the keyword "base" and passing them the parameters
            // --- --- //

            Console.WriteLine("Child constructor with 4 parameters.");
            Console.WriteLine("Remarks = {0}", param);
        }
        // --- OR --- //
        //public VIPMember(string param) : base( "John", 1, 2008)
        //{
        //    // --- IMPORTANT --- //
        //    //The constructor of the Parent class "with 3 parameter" is called 
        //    // We forced this behavior using the keyword "base" and passing them the parameters
        //    // --- --- //

        //    Console.WriteLine("Child constructor with 4 parameters.");
        //    Console.WriteLine("Remarks = {0}", param);
        //}

        //public override string ToString()
        //{
        //    return "\nName: " + name + "\nMember ID: " + memberID + "\nMember Since: " + memberSince +
        //    "\nTotal Annual Fee: " + annualFee;
        //}

        public void updateAnnualFee()
        {
            this.annualFee = 400; // dollars
        }

        //Method inherited from the parent class and modified, infact we use the override keyword
        public override void printMemberQualification()
        {
            Console.WriteLine("This is a VIP MEMBER !");
            //this.testVirtualInt = 2;
        }
    }
}
