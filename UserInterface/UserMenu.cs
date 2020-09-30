using System;
using System.Collections.Generic;
using PersonalRegister.Data;
using PersonalRegister.ManageCommands;
using PersonalRegister.Interfaces;
using PersonalRegister.UserInterface;


namespace PersonalRegister
{
    public class UserMenu
    {
        PeopleRegister peopleRegister;

        public UserMenu(PeopleRegister peopleRegister = null)
        {
            if(peopleRegister != null)
                this.peopleRegister = peopleRegister;
            else
                this.peopleRegister = new PeopleRegister();

        }

        public PeopleRegister  Run() 
        {
            IManagePeople managePeople = null;
            while(true) 
            {
                Console.Clear();
                ConstantMessages.DisplayMainMenuMessage();
                int userInput = ValueGetter.GetInt("->", clearConsole: false);
                switch(userInput)
                {
                    case 0:
                        Console.WriteLine("Wychodzenie z rejestru");
                        return peopleRegister;
                    case 1:
                        managePeople = new DisplayPeople();
                        break;
                    case 2:
                        managePeople = new AddNewPerson();
                        break;
                    case 3:
                        managePeople = new DeletePerson();
                        break;
                    case 4:
                        managePeople = new FindMatchedPeople();
                        break;
                    default:
                        Console.WriteLine("Wybrano błędą opcję");
                        ConstantMessages.PressKeyToContinue();
                        break;
                }
                if(managePeople is IManagePeople)
                {
                    peopleRegister = managePeople.Execute(peopleRegister); 
                    ConstantMessages.PressKeyToContinue();
                }
            }
        }

    }
}