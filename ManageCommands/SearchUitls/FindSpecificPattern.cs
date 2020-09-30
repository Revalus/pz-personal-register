using System;
using PersonalRegister.Data;
using PersonalRegister.Interfaces;
using System.Collections.Generic;

namespace PersonalRegister.ManageCommands.SearchUitls
{
    public class FindSpecificPattern : ISearchPersonData
    {
        public PeopleRegister Search(PeopleRegister people, string pattern)
        {

            Func<Person, string, bool> matchString = (person, pattern) => {
                string[] splitedString = person.ToString().Split(" ");
                foreach(string personData in splitedString)
                {
                    if(personData == pattern)
                        return true;
                }
                return false;
            };

            List<Person> selectedPeople = new List<Person>();
            foreach(Person person in people.peopleList)
            {
                if(matchString(person, pattern))
                    selectedPeople.Add(person);
            }
            people.peopleList = selectedPeople;
            return people;
        }
    }
}