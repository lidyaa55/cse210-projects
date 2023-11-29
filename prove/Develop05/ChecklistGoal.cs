class ChecklistGoal : Goal
{
    private int Target;
    private int Bonus;
    private int Completed;
    public ChecklistGoal(string name, string description, int points, int target, int bonus, int completed = 0) : base(name,description,points)
    {
        Target = target;
        Bonus = bonus;
        Completed = completed;
        Type = "Checklist";
    }

    public override void displayGoal()
    {
        if (Completed == Target)
        {
            Console.WriteLine($"[X] {Name} ({Description}) -- Completed {Completed}/{Target}");
        }
        else
        {
            Console.WriteLine($"[ ] {Name} ({Description}) -- Completed {Completed}/{Target}");
        }
    }

    public override string formatGoal()
    {
        return $"{Type},{Name},{Description},{Points},{Completed},{Target},{Bonus}";
    }

    public override int completeGoal()
    {
        Console.WriteLine($"Congratulations! You have earned {Points} points!");
        Completed++;
        return Points;
    }
}