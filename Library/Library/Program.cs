using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SimpleLibrary
{

    List<string> bookTitles = new List<string>();
    List<int> bookNumbers = new List<int>();


    int nextNumber = 1;
    public void Run()
    {
        bool keepRunning = true;
        Console.WriteLine("--- Простейший Менеджер Книг ---");

        while (keepRunning)
        {
            Console.WriteLine("Меню:");
            Console.WriteLine("1. Добавить книгу");
            Console.WriteLine("2. Показать книги");
            Console.WriteLine("3. Изменить название книги");
            Console.WriteLine("4. Выход");
            Console.Write("Выберите действие (введите число): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddBook();
                    break;
                case "2":
                    ShowBooks();
                    break;
                case "3":
                    EditBook();
                    break;
                case "4":
                    keepRunning = false;
                    Console.WriteLine("До свидания!");
                    break;
                default:
                    Console.WriteLine("Неправильный ввод. Попробуйте ещё раз.");
                    break;
            }
        }
    }
}