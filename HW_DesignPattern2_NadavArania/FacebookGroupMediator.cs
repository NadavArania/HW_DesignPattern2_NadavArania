using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPattern2_NadavArania
{
    internal class FacebookGroupMediator : IFacebookGroupMediator
    {
        List<IMember> members = new List<IMember>();

        public void RegisterUser(IMember member)
        {
            members.Add(member);
        }

        public void SendMessage(string message, IMember member)
        {
            foreach (IMember m in members)
            {
                if(m != member)
                {
                    m.Recive(message);
                }
            }
        }
    }
}
