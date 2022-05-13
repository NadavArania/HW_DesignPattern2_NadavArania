namespace HW_DesignPattern2_NadavArania
{
    public class Passport
    {
        public Person person;
        public int passportId;

        public Passport(Person person, int passportId)
        {
            this.person = person;
            this.passportId = passportId;
        }
    }
}