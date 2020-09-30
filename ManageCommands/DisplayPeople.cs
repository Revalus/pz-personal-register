using System;
using System.Collections.Generic;
using PersonalRegister.Data;
using PersonalRegister.Interfaces;

namespace PersonalRegister.ManageCommands
{
    public class DisplayPeople: IManagePeople
    {
        public PeopleRegister Execute(PeopleRegister people)
        {
            Console.Clear();
            foreach(Person person in people.peopleList){
                Console.WriteLine(person.ToString());
            }

            return people;
        }
    }
}