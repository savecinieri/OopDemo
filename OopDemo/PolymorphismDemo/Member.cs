using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo
{
    class Member
    {
        protected int annualFee;  //accessible by classes derived by Member
        private string name;
        private int memberID;
        private int memberSince;
        public virtual int testVirtualInt { get; set; }

        public Member()
        {
            Console.WriteLine("Parent Constructor with no parameter");
            this.testVirtualInt = 0;
        }

        public Member(string pName, int pMemberID, int pMemberSince)
        {
            Console.WriteLine("Parent Constructor with 3 parameters");
            this.testVirtualInt = 0;
            name = pName;
            memberID = pMemberID;
            memberSince = pMemberSince;
        }

        public override string ToString()
        {
            return "\nName: " + name + "\nMember ID: " + memberID + "\nMember Since: " + memberSince +
            "\nTotal Annual Fee: " + annualFee;
        }


        public virtual void printMemberQualification()
        {
            Console.WriteLine("This is a MEMBER !");
        }
    }

}
