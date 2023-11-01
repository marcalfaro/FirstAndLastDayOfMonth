using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndLastDayOfMonth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = new DateTime(2022, 8, 1);
            DateTime endDate = new DateTime(2023, 10, 1);

            while (startDate <= endDate)
            {
                // Calculate the last day of the current month
                DateTime lastDayOfMonth = new DateTime(startDate.Year, startDate.Month, DateTime.DaysInMonth(startDate.Year, startDate.Month));

                Console.WriteLine($"First day of {startDate:MMMM yyyy}: {startDate:yyyy-MM-dd}");
                Console.WriteLine($"Last day of {startDate:MMMM yyyy}: {lastDayOfMonth:yyyy-MM-dd}");
                Console.WriteLine();

                // Move to the first day of the next month
                startDate = startDate.AddMonths(1);
            }

            Console.ReadLine();
        }
    }
}
