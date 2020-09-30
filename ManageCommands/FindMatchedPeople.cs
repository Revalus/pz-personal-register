using System.Collections.Generic;
using PersonalRegister.UserInterface;
using PersonalRegister.Data;
using PersonalRegister.Interfaces;
using PersonalRegister.ManageCommands.SearchUitls;


namespace PersonalRegister.ManageCommands
{
    public class FindMatchedPeople : IManagePeople
    {
        public PeopleRegister Execute(PeopleRegister people)
        {
            ISearchPersonData searchPersonData;
            string searchInput = ValueGetter.GetString("Podaj poszukiwany wzorzec");
            if(searchInput.Contains("*"))
                searchPersonData = new FindPattern();
            else
                searchPersonData = new FindSpecificPattern();
            
            return new DisplayPeople().Execute(searchPersonData.Search(people, searchInput));
        }
    }
}