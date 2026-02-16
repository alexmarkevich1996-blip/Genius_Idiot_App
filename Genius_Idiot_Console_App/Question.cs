namespace Genius_Idiot_Console_App;

public class Question
{
    public string Text { get; private set; }
    public int Answer { get; private set; }

    public Question(string text, int answer)
    {
        Text = text;
        Answer = answer;
    }

    public string Print()
    {
        return $"Вопрос: {Text}";
    }
    
}