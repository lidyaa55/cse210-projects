public class ScriptureWord
{
    private string wordText;
    private bool isHidden;

    public ScriptureWord(string wordText, bool isHidden)
    {
        this.wordText = wordText;
        this.isHidden = isHidden;
    }

    public string GetWordText()
    {
        return wordText;
    }

    public bool IsHidden()
    {
        return isHidden;
    }

    public void HideWord()
    {
        isHidden = true;
    }
}
