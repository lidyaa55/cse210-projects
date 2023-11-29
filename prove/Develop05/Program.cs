
// Exceeding requirements by added a leveling system. 
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Goal> goals = new List<Goal>();
        int totalPoints = 0;
        int currentLevel = 0;
        displayMessage(totalPoints,currentLevel);

        Console.Write("Select a choice from the menu? ");
        int choice = int.Parse(Console.ReadLine());

        while (choice < 1 || choice >6)
        {
            Console.Write("Invalid choice. Select another choice? ");
            choice = int.Parse(Console.ReadLine());
        }

        while (choice != 6)
        {
            if (choice == 1)
            {
                displayGoalTypes();
                Console.Write("What type of goal would you like to create? ");
                int goalType = int.Parse(Console.ReadLine());

                while (goalType < 1 || goalType > 3)
                {
                    Console.Write("Invalid choice. Please choose another type of goal: ");
                    goalType = int.Parse(Console.ReadLine()); 
                }

                Console.Write("What is the name of your goal? ");
                string name = Console.ReadLine();

                Console.Write("What is a short description of it? ");
                string description = Console.ReadLine();

                Console.Write("What is the amount of points associated with this goal? ");
                int points = int.Parse(Console.ReadLine());

                if (goalType == 1)
                {
                    SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                    goals.Add(simpleGoal);
                }
                else if (goalType == 2)
                {
                    EternalGoal eternalGoal = new EternalGoal(name, description, points);
                    goals.Add(eternalGoal);
                }
                else
                {
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());

                    ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                    goals.Add(checklistGoal);
                }
            }
            else if (choice == 2)
            {
                Console.WriteLine("The goals are:");
                foreach (Goal goal in goals)
                {
                    goal.displayGoal();
                }
            }
            else if (choice == 3)
            {
                Console.Write("What would you like to name the file? ");
                string filename = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(filename))
                {
                    outputFile.WriteLine($"{totalPoints}");

                    foreach (Goal goal in goals)
                    {
                        outputFile.WriteLine($"{goal.formatGoal()}");
                    }
                }
            }
            else if (choice == 4)
            {
                Console.Write("What is the name of the file? ");
                string filename = Console.ReadLine();

                string[] lines = System.IO.File.ReadAllLines(filename);

                string[] firstParts = lines[0].Split(",");
                totalPoints = int.Parse(firstParts[0]);
                currentLevel = int.Parse(firstParts[1]);
                
                for (int i = 1; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(",");

                    if (parts[0] == "Simple")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),Convert.ToBoolean(parts[4]));
                        goals.Add(simpleGoal);
                    }
                    else if (parts[0] == "Eternal")
                    {
                        EternalGoal eternalGoal = new EternalGoal(parts[1],parts[2],int.Parse(parts[3]));
                        goals.Add(eternalGoal);
                    }
                    else
                    {                                           
                        ChecklistGoal checklistGoal = new ChecklistGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[5]),int.Parse(parts[6]),int.Parse(parts[4]));
                        goals.Add(checklistGoal);
                    }
                }
            }
            else if (choice == 5)
            {
                Console.WriteLine("The goals are:");
                int index = 1;
                foreach (Goal goal in goals)
                {
                    Console.WriteLine($"{index}. {goal.getName()}");
                    index++;
                }

                Console.Write("Which goal did you accomplish? ");
                int goalCompleted = int.Parse(Console.ReadLine());

                int pointsEarned = goals[goalCompleted-1].completeGoal();
                totalPoints += pointsEarned;

                if (totalPoints == 500)
                {
                    currentLevel = 1;
                    Console.WriteLine("Congratulations! You have moved up to level 1!");
                }
                else if (totalPoints == 1000)
                {
                    currentLevel = 2;
                    Console.WriteLine("Congratulations! You have moved up to level 2!");
                }
                else if (totalPoints == 1500)
                {
                    currentLevel = 3;
                    Console.WriteLine("Congratulations! You have moved up to level 3!");
                }
                else if (totalPoints == 2000)
                {
                    currentLevel = 4;
                    Console.WriteLine("Congratulations! You have moved up to level 4!");
                }
                Console.WriteLine($"You now have {totalPoints} points.");
            }

            displayMessage(totalPoints,currentLevel);
            Console.Write("Select a choice from the menu? ");
            choice = int.Parse(Console.ReadLine());

            while (choice < 1 || choice >6)
            {
                Console.Write("Invalid choice. Select another choice? ");
                choice = int.Parse(Console.ReadLine());
            }
        }
    }

    static void displayMessage(int totalPoints, int currentLevel)
    {
        Console.WriteLine($"\nYou have {totalPoints} points.");
        Console.WriteLine($"Your current level: {currentLevel}\n");
        Console.WriteLine("Menu:");
        Console.WriteLine("   1. Create New Goal");
        Console.WriteLine("   2. List Goals");
        Console.WriteLine("   3. Save Goals");
        Console.WriteLine("   4. Load Goals");
        Console.WriteLine("   5. Record Event");
        Console.WriteLine("   6. Quit");
    }

    static void displayGoalTypes()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("   1. Simple Goal");
        Console.WriteLine("   2. Eternal Goal");
        Console.WriteLine("   3. Checklist Goal");
    }
}