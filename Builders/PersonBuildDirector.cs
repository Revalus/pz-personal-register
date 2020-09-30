using PersonalRegister.Data;
namespace PersonalRegister.Builders
{
    public class PersonBuildDirector
    {
        private PersonBuilder personBuilder;
        public PersonBuildDirector()
        {
            personBuilder = new PersonBuilder();
        }

        public Person createPerson() 
        {
            personBuilder.SetName();
            personBuilder.SetLastname();
            personBuilder.SetSex();
            personBuilder.SetBirthday();
            personBuilder.SetAddress();
            return personBuilder.GetPerson();
        }
    }
}