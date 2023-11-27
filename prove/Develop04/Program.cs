// Program.cs
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("\nWelcome to the Mindfulness App!");

        while (true)
        {
            DisplayMenu();
            int choice = GetMenuChoice();

            switch (choice)
            {
                case 1:
                    StartActivity(new BreathingActivity(GetDuration()));
                    break;
                case 2:
                    StartActivity(new ReflectionActivity(GetDuration()));
                    break;
                case 3:
                    StartActivity(new ListingActivity(GetDuration()));
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\n1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Exit");
        Console.Write("Choose an activity: ");
    }

    static int GetMenuChoice()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                return choice;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

    static int GetDuration()
    {
        Console.Write("Enter the duration in seconds: ");
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int duration) && duration > 0)
            {
                return duration;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number for duration.");
            }
        }
    }

    static void StartActivity(Activity activity)
    {
        activity.Start();
        Console.WriteLine("\nPress any key to return to the main menu.");
        Console.ReadKey();
    }
}
