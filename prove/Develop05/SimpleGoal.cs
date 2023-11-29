class SimpleGoal : Goal
{
    private bool Completed;

    public SimpleGoal(string name, string description, int points, bool completed = false) : base(name,description,points)
    {
        Completed = completed;
        Type = "Simple";
    }

    public override void displayGoal()
    {
        if (Completed)
        {
            Console.WriteLine($"[X] {Name} ({Description})");
        }
        else
        {
            Console.WriteLine($"[ ] {Name} ({Description})");
        }
    }

    public override string formatGoal()
    {
        return $"{Type},{Name},{Description},{Points},{Completed}";
    }

    public override int completeGoal()
    {
        Console.WriteLine($"Congratulations! You have earned {Points} points!");
        Completed = true;
        return Points;
    }
}