using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("what's your grade?");
        string answer = Console.ReadLine();
        int percent =int.Parse(answer);

        string letter ="";

        if( percent >= 90)
        {
            letter ="A";
        }

        else if (percent >=80)
        {
            letter = "B";
        }

        else if (percent >= 70)
        {
            letter = "C";
        }
        else if(percent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
       Console.WriteLine($"your grade is :{letter}");

       if(percent >= 70)
       {
        Console.Write(" congrats you have passed");
       }
       else
       {
        Console.WriteLine("Better luck next time");
       }


    }
}