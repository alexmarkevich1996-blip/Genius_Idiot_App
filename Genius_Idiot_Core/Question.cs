namespace Genius_Idiot_Core;

public class Question
{
    public string Text { get; set; }
    public int Answer { get; set; }
    public int? UserAnswer { get; set; }

    public Question() 
    { }

    public Question(string text, int answer)
    {
        Text = text;
        Answer = answer;
        UserAnswer = null;
    }

    public string Print()
    {
        return $"Вопрос: {Text}";
    }
}