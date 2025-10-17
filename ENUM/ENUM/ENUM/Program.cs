using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENUM
{
    public enum TaskStatus
    {
        NotStarted,
        InProgress,
        Completed,
        Cancelled
    }
 public class EnumExample
    {
        public static void Main(string[] args)
        {
            TaskStatus myTaskStatus;
            myTaskStatus = TaskStatus.NotStarted;
            Console.WriteLine($"Текущий статус задачи: {myTaskStatus}");
            myTaskStatus = TaskStatus.Cancelled;
            Console.WriteLine($"Теперь статус задачи: {myTaskStatus}");
            Console.WriteLine($"Числовое значение статуса: {(int)TaskStatus.Cancelled}");
            Console.ReadKey();
        }
    }
}