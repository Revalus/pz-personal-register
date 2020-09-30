using System;
using PersonalRegister.Data;
using PersonalRegister.UserInterface;

namespace PersonalRegister.Builders
{
    public class PersonBuilder
    {  
        private Person person;

        public PersonBuilder(Person person = null) {
            if(person == null)
                this.person = new Person();
            else 
                this.person = person;
        }
        public void SetName() {
            person.Name = ValueGetter.GetString("Proszę podać imię");
        }
        public void SetLastname() {
            person.Lastname = ValueGetter.GetString("Proszę podać nazwisko");
        }
        public void SetSex() {
            person.Sex = ValueGetter.GetValueFromArray("Proszę wybrać płeć", new string[]{"Mężczyzna", "Kobieta"}) == 1?true:false;
        }
        public void SetBirthday() {
            int day = ValueGetter.GetInt("Podaj proszę dzień urodzin", clearConsole: true);
            int month = ValueGetter.GetInt("Podaj proszę miesiac urodzin", clearConsole: false);
            int year = ValueGetter.GetInt("Podaj proszę rok urodzin (w formacie YYYY)", clearConsole: false);
            try
            {
                person.Birthday = new DateTime(year, month, day);
            }
            catch (System.Exception)
            {
                Console.WriteLine("Wpisano niepoprawną datę, proszę spróbuj ponownie");
                ConstantMessages.PressKeyToContinue();
                SetBirthday();
            }
        }

        public void SetAddress() {
            AddressBuildDirector addressBuildDirector = new AddressBuildDirector();
            person.Address = addressBuildDirector.createAddress();
            
        }

        public Person GetPerson() => person;
    }
}

