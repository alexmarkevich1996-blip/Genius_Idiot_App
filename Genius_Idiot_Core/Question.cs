namespace Genius_Idiot_Core;

public class Question
{
    public string QuestionText { get; set; }
    public int Answer { get; set; }

    public Question() 
    { }

    public Question(string questionText, int answer)
    {
        QuestionText = questionText;
        Answer = answer;
    }
}