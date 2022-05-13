using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPattern2_NadavArania
{
    internal interface IFacebookGroupMediator
    {
        void RegisterUser(IMember member);
        void SendMessage(string message,IMember member);
    }
}
