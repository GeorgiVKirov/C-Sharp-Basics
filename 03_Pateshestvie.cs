using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voyage
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();

            if (budget <= 100)
            {
                Console.WriteLine("Somewhere in Bulgaria");
                if (season =="summer")
                {
                    Console.WriteLine($"Camp - {budget * 0.30:F2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Hotel - {budget * 0.70:F2}");
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                Console.WriteLine("Somewhere in Balkans");
                if (season == "summer")
                {
                    Console.WriteLine($"Camp - {budget * 0.40:F2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine($"Hotel - {budget * 0.80:F2}");
                }
            }
            else
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {budget * 0.90:F2}");
            }
        }
    }
}
