class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
        
        Entry entry = new Entry
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        };
        entries.Add(entry);
    }

    public List <Entry> answers = new List<Entry>();

    public void DisplayEntries()
    {
        //  display them
        foreach (var entry in entries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveToFile(string fileName)
{
    using (StreamWriter file = new StreamWriter(fileName))
    {
        foreach (var entry in entries)
        {
            string dateText = entry.Date.ToShortDateString();
            
            file.WriteLine($"Date: {dateText}");
            file.WriteLine($"Prompt: {entry.Prompt}");
            file.WriteLine($"Response: {entry.Response}\n");
        }
    }
    Console.WriteLine("file saved to journal successfully.");
}

public void LoadFromFile(string fileName)
{
    if (File.Exists(fileName))
    {
        entries.Clear(); 
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.StartsWith("Date: "))
                {
                    DateTime date;
                    if (DateTime.TryParse(line.Replace("Date: ", ""), out date))
                    {
                        string prompt = reader.ReadLine().Replace("Prompt: ", "");
                        string response = reader.ReadLine().Replace("Response: ", "");

                        Entry entry = new Entry
                        {
                            Date = date,
                            Prompt = prompt,
                            Response = response
                        };

                        entries.Add(entry);
                    }
                }
            }
        }
        Console.WriteLine("journal loaded successfully!");
    }
    else
    {
        Console.WriteLine("File not found.");
    }
}

}






