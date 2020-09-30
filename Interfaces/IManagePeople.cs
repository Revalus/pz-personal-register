using System.Collections.Generic;
using PersonalRegister.Data;

namespace PersonalRegister.Interfaces
{
    public interface IManagePeople
    {
        PeopleRegister Execute(PeopleRegister people);
    }
}