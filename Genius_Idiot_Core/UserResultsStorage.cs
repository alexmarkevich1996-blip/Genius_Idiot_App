using System.Reflection.Emit;

namespace Genius_Idiot_Core;

public class UserResultsStorage
{
    public List<UserResult> Results { get; set; }

    public UserResultsStorage()
    {
        Results = new List<UserResult>();
    }

}