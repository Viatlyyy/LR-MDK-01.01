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
    private void AddBook()
    {
        Console.WriteLine("--- Добавление книги ---");
        Console.Write("Введите название книги: ");
        string newTitle = Console.ReadLine();


        if (string.IsNullOrWhiteSpace(newTitle))
        {
            Console.WriteLine("Название книги не может быть пустым!");
            return;
        }


        bookTitles.Add(newTitle);

        bookNumbers.Add(nextNumber);

        Console.WriteLine($"Книга '{newTitle}' добавлена под номером {nextNumber}.");
        nextNumber++;
    }
    private void ShowBooks()
    {
        Console.WriteLine("--- Список книг ---");

        if (bookTitles.Count == 0)
        {
            Console.WriteLine("Книг пока нет.");
            return;
        }


        for (int i = 0; i < bookTitles.Count; i++)
        {


            Console.WriteLine($"Номер: {bookNumbers[i]} | Название: {bookTitles[i]}");
        }
    }
    private void EditBook()
    {
        Console.WriteLine("--- Изменение названия книги ---");

        ShowBooks();


        if (bookTitles.Count == 0)
        {
            return;
        }

        Console.Write("Введите номер книги, которую хотите изменить: ");
        string inputNumber = Console.ReadLine();


        if (!int.TryParse(inputNumber, out int numberToEdit))
        {
            Console.WriteLine("Ошибка: Введите корректный номер книги (число).");
            return;
        }


        int indexToEdit = -1;
        for (int i = 0; i < bookNumbers.Count; i++)
        {
            if (bookNumbers[i] == numberToEdit)
            {
                indexToEdit = i;
                break;
            }
        }


        if (indexToEdit == -1)
        {
            Console.WriteLine($"Книга с номером {numberToEdit} не найдена.");
            return;
        }


        Console.WriteLine($"Текущее название: {bookTitles[indexToEdit]}");
        Console.Write("Введите новое название: ");
        string newTitle = Console.ReadLine();


        if (string.IsNullOrWhiteSpace(newTitle))
        {
            Console.WriteLine("Новое название не может быть пустым. Изменение отменено.");
            return;
        }


        bookTitles[indexToEdit] = newTitle;

        Console.WriteLine($"Название книги (Номер: {numberToEdit}) успешно изменено на '{newTitle}'.");
    }
}
public class Program
{
    public static void Main(string[] args)
    {

        SimpleLibrary mySimpleLibrary = new SimpleLibrary();

        mySimpleLibrary.Run();
    }
}