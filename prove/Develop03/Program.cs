
class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Scripture Memorization Program!");

        // Create a Scripture object
        ScriptureReference reference = new ScriptureReference("Proverbs 1:07");
        List<ScriptureWord> words = new List<ScriptureWord>
        {
            new ScriptureWord("The", false),
            new ScriptureWord("fear", false),
            new ScriptureWord("of", false),
            new ScriptureWord("the", false),
            new ScriptureWord("lord", false),
            new ScriptureWord("is", false),
            new ScriptureWord("the", false),
            new ScriptureWord("beginning", false),
            new ScriptureWord("of", false),
            new ScriptureWord("knowledge:", false),
            new ScriptureWord("but", false),
            new ScriptureWord("fools", false),
            new ScriptureWord("despise", false),
            new ScriptureWord("wisdom", false),
            new ScriptureWord("and", false),
            new ScriptureWord("instruction.", false)
        };

        Scripture scripture = new Scripture(reference, words);

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Scripture:");
            scripture.Display();
            Console.WriteLine("\nPress Enter to hide a random word or type 'quit' to exit.");

            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord();

            if (scripture.AllWordsHidden())
            {
                Console.Clear();
                Console.WriteLine("All words are hidden. Scripture is complete.");
                break;
            }
        }
    }
}
