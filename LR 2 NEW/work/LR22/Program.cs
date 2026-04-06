using System;
using System.Collections.Generic;
namespace LR22
{
    class Program
    {
        static void Print(List<string> clients)
        {
            Console.WriteLine(string.Join(", ", clients));
        }
        static void Main(string[] args)
        {
            string[] services = new string[] { "Консультация психолога", "Тренировка с тренером", "Составление рациона" };
            var (clients, counts) = InputModule.InputClientByService();

            string userQuery = InputModule.InputUserQuery();

            int indexService = SearchingModule.FindIndexService(userQuery, services);
            if (indexService < 0)
            {
                Console.WriteLine("Указана несуществующая услуга");
                return;
            }

            var (clientsUserService, countsUserService) = SearchingModule.FindAllClientsByService(indexService, clients, counts);

            AnalysisDataModule.SortClients(clientsUserService, countsUserService);
            Print(clientsUserService);
            Console.Write("Среднее количество обращений по выбранной вами услуге = " + AnalysisDataModule.CalculateAverage(countsUserService));

        }
    }
}