using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPattern2_NadavArania
{
    internal interface IInteriorOffice
    {
        public void GetAdvancePersonDetails();

        public void CallPolice();

        public void Cameras();

        public void SafeLockDown();

        public void SafeUnlockDown();
    }
}
