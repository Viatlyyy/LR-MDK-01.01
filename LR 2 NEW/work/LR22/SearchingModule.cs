using System.Collections.Generic;
namespace LR22
{
    public class SearchingModule
    {
        static public int FindIndexService(string userQuery, string[] services)
        {
            for (int index = 0; index < services.Length; index++)
            {
                string valueService = services[index].ToLower();
                if (valueService == userQuery.ToLower())
                {
                    return index;
                }
            }
            return -1;
        }

        static public (List<string>, List<int>) FindAllClientsByService(int indexService,
                                                                        List<string>[] allClients,
                                                                        List<int>[] counts)
        {
            List<string> clientsByService = new List<string>();
            List<int> countsByService = new List<int>();

            clientsByService = allClients[indexService];
            countsByService = counts[indexService];

            return (clientsByService, countsByService);
        }
    }
}
