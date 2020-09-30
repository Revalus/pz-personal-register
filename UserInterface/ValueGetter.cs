using System;
namespace PersonalRegister.UserInterface
{
    static public class ValueGetter
    {
        public static string GetString(string message, bool clearConsole = true, bool allowEmpty = false) {
            if(clearConsole) Console.Clear();
            Console.Write($"{message}: ");
            string userInput = Console.ReadLine();
            if(userInput == "" && !allowEmpty) {
                Console.WriteLine("Podana wartość nie może być pusta, proszę spróbować ponownie");
                return GetString(message, clearConsole, allowEmpty);
            }
            return userInput;
        }
        public static int GetInt(string message, bool clearConsole = true, bool allowEmpty = false, bool retryIfError = true) {
            string userInput = ValueGetter.GetString(message, clearConsole, allowEmpty);
            if(userInput == "" && allowEmpty) return -1;
            try{
                return int.Parse(userInput);
            } catch(System.FormatException) {
                if(retryIfError) {
                    Console.WriteLine("Niestety wprowadzona wartość nie jest liczbą, proszę spróbować ponownie");
                    Console.ReadKey();
                    return GetInt(message);
                }
            }
            return -1;
        }

        public static int GetValueFromArray(string message, string[] choices, bool clearConsole = true, bool allowEmpty = false, bool retryIfError = true) {
            for(int i = 0; i < choices.Length; i++) {
                Console.WriteLine($"{i} - {choices[i]}");
            }
            Console.WriteLine();
            return GetInt(message, clearConsole: false, allowEmpty, retryIfError);
        }        
    }
}