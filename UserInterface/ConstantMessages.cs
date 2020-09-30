using System;

namespace PersonalRegister.UserInterface
{
    static public class ConstantMessages
    {
        static public void DisplayMainMenuMessage() 
        {
            Console.WriteLine("1) Wyświetl ludzi w rejestrze");
            Console.WriteLine("2) Dodaj osobę do rejestru");
            Console.WriteLine("3) Usuń osobę z rejestru");
            Console.WriteLine("4) Znajdź osobę w rejestrze");
            Console.WriteLine();
            Console.WriteLine("0) Wyjdź");
        }

        static public void PressKeyToContinue() 
        {
            Console.WriteLine("Wciśnij przycisk aby kontynuować...");
            Console.ReadKey();
        }
    }
}