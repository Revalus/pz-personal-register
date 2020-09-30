
using PersonalRegister.Data;
using PersonalRegister.Interfaces;

using System.Linq;
using System.Collections.Generic;


namespace PersonalRegister.ManageCommands.SearchUitls
{
    public class FindPattern : ISearchPersonData
    {
        public PeopleRegister Search(PeopleRegister people, string pattern)
        {
            pattern = pattern.Replace("*", "");
            IEnumerable<Person> selectedPeople = from person in people.peopleList
                                                 where person.ToString().Contains(pattern)
                                                 select person;
            people.peopleList = selectedPeople.ToList();
            return people;
        }
    }
}