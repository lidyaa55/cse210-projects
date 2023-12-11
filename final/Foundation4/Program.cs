
class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        // Running 
        Running running = new Running("02/01/24",30,2.5);
        activities.Add(running);

        // swimming
        Swimming swimming = new Swimming("02/01/24",30,20.0);
        activities.Add(swimming);

        // cycling
        Cycling cycling = new Cycling("02/01/24",40,15.0);
        activities.Add(cycling);

        foreach (Activity activity in activities){
            activity.getSunmmary();
            Console.WriteLine();
        }
    }
}