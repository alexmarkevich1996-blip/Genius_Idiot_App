namespace Genius_Idiot_Core;

public class UserResult
{
    public string Level { get; set; }
    public int Score { get; set; }
    public DateTime Date { get; set; }

    public UserResult(string level, int score)
    {
        Level = level;
        Score = score;
        Date = DateTime.Now;
    }
}