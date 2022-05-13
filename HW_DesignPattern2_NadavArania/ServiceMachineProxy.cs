using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPattern2_NadavArania
{
    internal class ServiceMachineProxy : IServiceMachine
    {
        private InteriorOffice realIO;

        public ServiceMachineProxy(InteriorOffice realIO)
        {
            this.realIO = realIO;
        }

        public void ChangeAddress()
        {
            realIO.ChangeAddress();
        }

        public Passport PassportRenew()
        {
            return realIO.PassportRenew();
        }

        public Person PersonDetails()
        {
            return realIO.PersonDetails();
        }
    }
}
