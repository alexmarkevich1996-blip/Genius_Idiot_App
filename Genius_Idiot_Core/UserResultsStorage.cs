using System.Reflection.Emit;

namespace Genius_Idiot_Core;

public class UserResultsStorage
{
    public List<UserResult> Results { get; set; }

    public UserResultsStorage()
    {
        Results = new List<UserResult>();
    }

    public void Add(string level, int finalScore)
    {
        var result = new UserResult(level, finalScore);
        Results.Add(result);
    }

    public UserResult GetLastResult()
    {
        UserResult lastResult = Results.Last();
        return lastResult;
    }
}