using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPattern2_NadavArania
{
    internal interface IServiceMachine
    {
        public void ChangeAddress();

        public Person PersonDetails();

        public Passport PassportRenew();
    }
}
