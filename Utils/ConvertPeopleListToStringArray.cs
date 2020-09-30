using System.Collections.Generic;
using PersonalRegister.Data;

namespace PersonalRegister.Utils
{
    public class ConvertPeopleListToStringArray
    {
        public  static string[] Convert(List<Person> people) {
            string[] peopleStringArray = new string[people.Count];
            for(int i = 0; i < people.Count; i++)
            {
                string personString = people[i].ToString();
                peopleStringArray[i] = personString;
            }
            return peopleStringArray;
        }
    }
}