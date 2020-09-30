using System.Collections.Generic;
using PersonalRegister.Builders;
using PersonalRegister.Data;
using PersonalRegister.Interfaces;

namespace PersonalRegister.ManageCommands
{
    public class AddNewPerson : IManagePeople
    {
        public PeopleRegister Execute(PeopleRegister people)
        {
            people.peopleList.Add(new PersonBuildDirector().createPerson());
            return people;
        }
    }
}