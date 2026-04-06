using System;
using System.Collections.Generic;

namespace LR22
{
    public class InputModule
    {
        static public (List<string>[], List<int>[]) InputClientByService()
        {
            List<string>[] clientsByServices = new List<string>[3] { new List<string>(),
                                                                     new List<string>(),
                                                                     new List<string>() };
            List<int>[] counts = new List<int>[3] { new List<int>(),
                                                    new List<int>(),
                                                    new List<int>(), };
            // Заполняем клиентов в услугу Консультация психолога
            clientsByServices[0].Add("Романова Елена");
            counts[0].Add(6);
            clientsByServices[0].Add("Беляев Алексей");
            counts[0].Add(3);
            clientsByServices[0].Add("Гришина Дарья");
            counts[0].Add(9);
            clientsByServices[0].Add("Соболев Кирилл");
            counts[0].Add(2);
            clientsByServices[0].Add("Тимофеева Виктория");
            counts[0].Add(5);

            // Заполняем клиентов в услугу Тренировка с тренером
            clientsByServices[1].Add("Шестаков Артём");
            counts[1].Add(7);
            clientsByServices[1].Add("Мельникова Алина");
            counts[1].Add(4);
            clientsByServices[1].Add("Гусев Даниил");
            counts[1].Add(8);
            clientsByServices[1].Add("Полякова Вероника");
            counts[1].Add(3);
            clientsByServices[1].Add("Кудряшов Максим");
            counts[1].Add(6);

            // Заполняем клиентов в услугу Составление рациона
            clientsByServices[2].Add("Лапина Екатерина");
            counts[2].Add(5);
            clientsByServices[2].Add("Фролов Николай");
            counts[2].Add(2);
            clientsByServices[2].Add("Борисова Анжелика");
            counts[2].Add(7);
            clientsByServices[2].Add("Ткаченко Григорий");
            counts[2].Add(4);
            clientsByServices[2].Add("Дементьева Полина");
            counts[2].Add(8);

            return (clientsByServices, counts);
        }

        static public string InputUserQuery()
        {
            Console.Write("Введите, пожалуйста, услугу (консультация психолога/тренировка с тренером/составление рациона): ");
            return Console.ReadLine();
        }
    }
}