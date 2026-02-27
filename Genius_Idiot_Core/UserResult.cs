namespace Genius_Idiot_Core;

public class UserResult
{
    public string Level { get; set; }
    public int Score { get; set; }
    public DateTime Date { get; set; }

    public UserResult()
    { }

    public UserResult(string level, int score, DateTime dateTime)
    {
        Level = level;
        Score = score;
        Date = dateTime;
    }
    public UserResult(string level, int score) : this(level, score, DateTime.Now)
    {
    }
}