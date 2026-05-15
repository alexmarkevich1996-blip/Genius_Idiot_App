namespace Genius_Idiot_Core;

public class User
{
    public string Name { get; private set; }
    
    public User()
    {
        Name = "Unknown";
    }

    public User(string name)
    {
        Name = name;
    }
}