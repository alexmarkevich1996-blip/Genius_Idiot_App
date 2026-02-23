namespace Genius_Idiot_Console_App;

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