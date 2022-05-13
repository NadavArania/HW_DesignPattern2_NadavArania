using HW_DesignPattern2_NadavArania;

internal class Program
{
    static void Main(string[] args)
    {
        ///Proxy
        
        //InteriorOffice interiorOffice = new InteriorOffice();
        //interiorOffice.SafeUnlockDown();
        //interiorOffice.Cameras();

        //IServiceMachine serviceMachine = new ServiceMachineProxy(interiorOffice);
        //ServiceMachine(serviceMachine);

        ///Mediator
       
        //IFacebookGroupMediator groupMediator = new FacebookGroupMediator();

        //IMember haim = new Member(groupMediator, "Haim");
        //IMember ben = new Member(groupMediator, "Ben");
        //IMember noam = new Member(groupMediator, "Noam");
        //IMember din = new Member(groupMediator, "Din");

        //groupMediator.RegisterUser(haim);
        //groupMediator.RegisterUser(ben);
        //groupMediator.RegisterUser(noam);
        //groupMediator.RegisterUser(din);

        //haim.Send("Hello everyone!");
        //ben.Send("Long time no see Haim!");

    }

    static void ServiceMachine(IServiceMachine servinceMachineProxy)
    {
        Person p = servinceMachineProxy.PersonDetails();
        Passport pass = servinceMachineProxy.PassportRenew();
    }
}