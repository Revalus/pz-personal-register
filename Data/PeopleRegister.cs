using System.Xml.Serialization;
using System.Collections.Generic;

namespace PersonalRegister.Data
{
    [XmlRoot("PeopleRegister")]
    public class PeopleRegister
    {
        public List<Person> peopleList;
        public PeopleRegister()
        {
            peopleList = new List<Person>();
        }
    }
}