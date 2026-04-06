using System.Collections.Generic;
namespace LR22
{
    public class AnalysisDataModule
    {
        static public void SortClients(List<string> clients, List<int> counts)
        {
            for (int i = 0; i < counts.Count; i++)
            {
                for (int j = 0; j < counts.Count - 1; j++)
                {
                    bool condition = counts[j + 1] > counts[j];
                    if (condition)
                    {
                        int temp_counts = counts[j];
                        counts[j] = counts[j + 1];
                        counts[j + 1] = temp_counts;

                        string temp_clients = clients[j];
                        clients[j] = clients[j + 1];
                        clients[j + 1] = temp_clients;
                    }
                }
            }
        }

        static public int CalculateAverage(List<int> counts)
        {
            int sum = 0;
            foreach (int count in counts)
            {
                sum += count;
            }

            return sum/counts.Count;
        }
    }
}
