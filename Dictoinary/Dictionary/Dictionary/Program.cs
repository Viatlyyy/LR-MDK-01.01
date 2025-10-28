using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
   
    public class DictionaryExample
    {
        public static void Main(string[] args)
        {
            
            Dictionary<string, List<string>> myDictionary = new Dictionary<string, List<string>>();

            myDictionary.Add("Фрукты", new List<string>
        {
            "Яблоко",
            "Банан",
            "Апельсин",
            "Груша",
            "Гранат"
        });
            
            myDictionary.Add("Овощи", new List<string>
        {
            "Морковь",
            "Картофель",
            "Огурец",
            "Помидор",
            "Лук"
           
        });

            myDictionary.Add("Ягоды", new List<string>
        {
            "Клубника",
            "Малина",
            "Ежевика",
            "Земляника"
        });

            
            DisplayEntryCount(myDictionary);
        }

        
        public static void DisplayEntryCount(Dictionary<string, List<string>> dictionary)
        {
            Console.WriteLine("Введите ключ, чтобы узнать количество записей:");
            string userInput = Console.ReadLine();

            string lowerUserInput = userInput.ToLower();
            string foundKey = null;

            foreach (string key in dictionary.Keys)
            {
                if (key.ToLower() == lowerUserInput)
                {
                    foundKey = key;
                    break; 
                }
            }

            if (foundKey != null)
            {
                List<string> entries = dictionary[foundKey];
                Console.WriteLine($"Количество записей для ключа '{foundKey}': {entries.Count}");
            }
            else
            {
                Console.WriteLine($"Ключ '{userInput}' не найден в словаре.");
            }
        }
    }
}