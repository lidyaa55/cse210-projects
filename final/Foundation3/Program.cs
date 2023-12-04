using System;

class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Cityville", "State", "12345");
        Address address2 = new Address("456 Oak St", "Townsville", "State", "67890");
        Address address3 = new Address("789 Pine St", "Villagetown", "State", "54321");

        Event genericEvent = new Event("Generic Event", "This is a generic event.", DateTime.Now, new TimeSpan(18, 30, 0), address1);
        Lecture lectureEvent = new Lecture("Awesome Lecture", "An amazing talk about something interesting.", DateTime.Now.AddDays(7), new TimeSpan(14, 0, 0), address2, "John Doe", 100);
        Reception receptionEvent = new Reception("Special Reception", "Join us for a special celebration.", DateTime.Now.AddDays(14), new TimeSpan(20, 0, 0), address3, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Community Picnic", "A day of fun in the sun.", DateTime.Now.AddDays(30), new TimeSpan(12, 0, 0), address1, "Please check the weather updates.");

        Console.WriteLine("Generic Event:\n");
        Console.WriteLine(genericEvent.GenerateStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(genericEvent.GenerateFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(genericEvent.GenerateShortDescription());

        Console.WriteLine("\n---------------------------\n");

        Console.WriteLine("Lecture Event:\n");
        Console.WriteLine(lectureEvent.GenerateStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lectureEvent.GenerateFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lectureEvent.GenerateShortDescription());

        Console.WriteLine("\n---------------------------\n");

        Console.WriteLine("Reception Event:\n");
        Console.WriteLine(receptionEvent.GenerateStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(receptionEvent.GenerateFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(receptionEvent.GenerateShortDescription());

        Console.WriteLine("\n---------------------------\n");

        Console.WriteLine("Outdoor Gathering Event:\n");
        Console.WriteLine(outdoorEvent.GenerateStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(outdoorEvent.GenerateFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoorEvent.GenerateShortDescription());
    }
}
