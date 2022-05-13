using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPattern2_NadavArania
{
    internal class InteriorOffice : IInteriorOffice, IServiceMachine
    {
        private Person person;
        private Passport passport;

        public void CallPolice()
        {
            Console.WriteLine("Calling the police!");
        }

        public void Cameras()
        {
            Console.WriteLine("Showing cameras screens!");
        }

        public void ChangeAddress()
        {
            Console.WriteLine("Changing address!");
        }

        public void GetAdvancePersonDetails()
        {
            Console.WriteLine("Get Advance person details!");
        }

        public Passport PassportRenew()
        {
            return passport;
        }

        public Person PersonDetails()
        {
            return person;
        }

        public void SafeLockDown()
        {
            Console.WriteLine("Safe lock down!");
        }

        public void SafeUnlockDown()
        {
            Console.WriteLine("Safe unlock down!");
        }
    }
}
