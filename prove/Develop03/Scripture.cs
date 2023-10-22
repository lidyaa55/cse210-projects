
public class Scripture
{
    private ScriptureReference reference;
    private List<ScriptureWord> words;

    public Scripture(ScriptureReference reference, List<ScriptureWord> words)
    {
        this.reference = reference;
        this.words = words;
    }

    public void Display()
    {
        Console.WriteLine(reference.GetReference());
        foreach (var word in words)
        {
            if (word.IsHidden())
                Console.Write("___ ");
            else
                Console.Write(word.GetWordText() + " ");
        }
        Console.WriteLine();
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden());
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int randomIndex;
        do
        {
            randomIndex = random.Next(0, words.Count);
        } while (words[randomIndex].IsHidden());

        words[randomIndex].HideWord();
    }
}
