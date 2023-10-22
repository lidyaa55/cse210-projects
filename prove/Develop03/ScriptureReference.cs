public class ScriptureReference
{
    private string referenceText;

    public ScriptureReference(string referenceText)
    {
        this.referenceText = referenceText;
    }

    public string GetReference()
    {
        return referenceText;
    }
}
