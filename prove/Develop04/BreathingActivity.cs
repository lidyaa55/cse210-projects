
class BreathingActivity : Activity
{
    public BreathingActivity(int duration) : base(duration) { }

    public override void Start()
    {
        base.Start();
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

        PerformActivity("Breathe in...");
        PerformActivity("Breathe out...");

        base.End();
    }

    private void PerformActivity(string message)
    {
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(message);
            Pause(1);
        }
    }
}
