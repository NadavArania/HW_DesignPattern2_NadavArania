using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_DesignPattern2_NadavArania
{
    internal class Member : IMember
    {
        IFacebookGroupMediator groupMediator;
        string name;

        public Member(IFacebookGroupMediator groupMediator, string name)
        {
            this.groupMediator = groupMediator;
            this.name = name;
        }

        public void Recive(string reciveMessage)
        {
            Console.WriteLine($"{name} recived message {reciveMessage}");
        }

        public void Send(string sendMessage)
        {
            Console.WriteLine($"{name} sent message {sendMessage}");
            groupMediator.SendMessage(sendMessage, this);
        }
    }
}
