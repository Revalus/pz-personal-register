using PersonalRegister.Data;

namespace PersonalRegister.Interfaces
{
    public interface ISearchPersonData
    {
        PeopleRegister Search(PeopleRegister people, string pattern);
    }
}