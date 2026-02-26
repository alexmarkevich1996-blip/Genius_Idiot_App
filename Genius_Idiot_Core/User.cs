namespace Genius_Idiot_Core;

public class User
{
    public string Name { get; private set; }
    public UserResultsStorage userResults { get; private set; }
    
    public User()
    {
        Name = "Unknown";
        userResults = new UserResultsStorage();
    }

    public User(string name)
    {
        Name = name;
        userResults = new UserResultsStorage();
    }
}