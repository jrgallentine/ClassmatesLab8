using System;
using System.Collections.Generic;

namespace ClassmatesLab8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> comrades = new List<string>()
            {
                "Grace",
                "Wendi",
                "Ramon",
                "Antonio",
                "Jeremiah",
                "Joshua C.",
                "Nathaniel",
                "Joshua G.",
                "Nick",
                "Juliana",
                "Jeffrey",
                "Stephen",
                "Tommy"
            };
            List<string> foods = new List<string>()
            {
                "Sweaty potato fries",
                "Salami", "Burgers",
                "Focaccia Barese",
                "Burgers",
                "Naleśniki",
                "Steak", "Falafel",
                "Tacos",
                "Tacos",
                "Steak",
                "Mooncakes",
                "Chicken Curry"
            };
            List<string> homes = new List<string>()
            {
                "Mesa, AZ",
                "Detroit, MI",
                "Tigard, OR",
                "Beverly Hills, MI",
                "Crystal, MI",
                "Novi, MI",
                "Berkley, MI",
                "Baldwin, MI",
                "Canton, MI",
                "Denver, CO",
                "Detroit, MI",
                "Moon, Epoch J2000",
                "Raleigh, NC"
            };

            int comID = 0;
            string input = "-1";
            while (true)
            {
                Console.Write($"Which C# student would you like to learn more about? (enter a number 1-{comrades.Count}): ");
                Int32.TryParse(Console.ReadLine(), out comID);
                if (comID >= 1 && comID <= comrades.Count + 1)
                {   
                    Console.Write($"Student {comID} is {comrades[comID - 1]}. What would you like to know about {comrades[comID - 1]}? (enter 'hometown' or 'favorite food'): ");
                    input = Console.ReadLine();

                    if (input.ToLower().Contains("ho") || input.ToLower().Contains("tow"))
                    {
                        Console.WriteLine($"{comrades[comID - 1]}'s hometown is {homes[comID - 1]}.");
                        continue;
                    }

                    else if (input.ToLower().Contains("fo") || input.ToLower().Contains("fa"))
                    {
                        Console.WriteLine($"{comrades[comID - 1]}'s favorite food is {foods[comID - 1]}.");
                        continue;
                    }

                }
                else 
                {
                    Console.WriteLine($"Try again:");
                    continue;
                }

            }

        }

    }
}
