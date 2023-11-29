class Goal
{
    protected int Points;
    protected string Name;
    protected string Description;
    protected string Type;

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public virtual void displayGoal()
    {
        Console.WriteLine($"[ ] {Name} ({Description})");
    }

    public virtual string formatGoal()
    {
        return $"{Type},{Name},{Description},{Points}";
    }

    public string getName()
    {
        return Name;
    }

    public virtual int completeGoal()
    {
        Console.WriteLine($"Congratulations! You have earned {Points} points!");
        return Points;
    }
}