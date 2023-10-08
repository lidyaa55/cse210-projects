 class Program
 {
    static void Main(string[] args)
    {
       PromptGenerator promptGenerator = new PromptGenerator();
       Journal journal = new Journal();
       bool exitProgram = false;

     while (!exitProgram)
{
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Exit");
        int choice = int.Parse(Console.ReadLine());

        
        switch (choice)
           {
              case 1:
                   string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Response: ");
                    string response = Console.ReadLine();
                    journal.AddEntry(prompt, response);
                    break;
                case 2:
                     journal.DisplayEntries();
                     break;
                 case 3:
                    Console.Write("Enter a filename to save the journal: ");
                     string saveFileName = Console.ReadLine();
                    journal.SaveToFile(saveFileName);
                    break;
                 case 4:
                     Console.Write("Enter a filename to load the journal: ");
                     string loadFileName = Console.ReadLine();
                    journal.LoadFromFile(loadFileName);
                    break;
                case 5:
                     exitProgram = true;
                    break;
              default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

         }
        }}
 }

   
   
   
   