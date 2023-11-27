
class Activity
{
    protected int duration;

    public Activity(int duration)
    {
        this.duration = duration;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Starting {GetType().Name}...");
        Console.WriteLine($"Duration: {duration} seconds");
        Console.WriteLine("Get ready to begin.");
        Pause(3);
    }

    public virtual void End()
    {
        Console.WriteLine($"Good job! You have completed {GetType().Name} for {duration} seconds.");
    }

    protected void Pause(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
        }
        Console.WriteLine();
    }
}
