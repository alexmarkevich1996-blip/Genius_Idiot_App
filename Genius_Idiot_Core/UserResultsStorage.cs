namespace Genius_Idiot_Console_App;

public class UserResultsStorage
{
    public List<UserResult> Results { get; set; }

    public UserResultsStorage()
    {
        Results = new List<UserResult>();
    }

    public void Add(UserResult result)
    {
        Results.Add(result);
    }
}