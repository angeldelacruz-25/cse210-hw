
using System;
using System.Collections.Generic;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Keep track of completed activities
        Dictionary<string, int> activityLog = new Dictionary<string, int>();

        activityLog["Breathing Activity"] = 0;
        activityLog["Reflection Activity"] = 0;
        activityLog["Listing Activity"] = 0;

        while (true)
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View activity statistics");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();

                activityLog["Breathing Activity"]++;
            }
            else if (choice == "2")
            {
                ReflectionActivity activity = new ReflectionActivity();
                activity.Run();

                activityLog["Reflection Activity"]++;
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();

                activityLog["Listing Activity"]++;
            }
            else if (choice == "4")
            {
                Console.Clear();

                Console.WriteLine("Activity Statistics");
                Console.WriteLine("--------------------------");

                foreach (var activity in activityLog)
                {
                    Console.WriteLine($"{activity.Key}: {activity.Value} times");
                }

                Console.WriteLine();
                Console.WriteLine("Press Enter to return to the menu.");
                Console.ReadLine();
            }
            else if (choice == "5")
            {
                Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Please select 1, 2, 3, 4, or 5.");
                Thread.Sleep(2000);
            }
        }
    }
}
