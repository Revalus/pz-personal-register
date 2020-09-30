using System.Collections.Generic;
using PersonalRegister.UserInterface;
using PersonalRegister.Data;
using PersonalRegister.Interfaces;
using PersonalRegister.Utils;
namespace PersonalRegister.ManageCommands
{
    public class DeletePerson: IManagePeople
    {
        public PeopleRegister Execute(PeopleRegister people)
        {
            
            PeopleRegister matchedPeople = new FindMatchedPeople().Execute(people);
            int selectedIndex = ValueGetter.GetValueFromArray(
                "Proszę wybrać indeks osoby do usunięcia (wciśnij enter, jeśli nie chcesz nikgo usunąć)",
                ConvertPeopleListToStringArray.Convert(people.peopleList), 
                allowEmpty: true
            );
            if(selectedIndex == -1)
                return people;

            people.peopleList.RemoveAt(selectedIndex);
            return people;

        }
    }
}