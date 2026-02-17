namespace Genius_Idiot_Console_App;

public class User
{
    public string Name { get; private set; }
    public UserResultsStorage userResults { get; private set; }
    
    public User()
    {
        Name = SetUserName();
        userResults = new UserResultsStorage();
    }
    private string SetUserName()
    {
        while (true)
        {
            Console.Write("Пожалуйста, введите ваше имя: ");
            string userName = Console.ReadLine();
            if (userName == string.Empty)
            {
                Console.WriteLine("Вы не ввели имя. Просим вас повторить попытку.");
            }
            else if (userName.Contains('-'))
            {
                Console.WriteLine($"Недопустимо писать имя со спец символом \"-\"");
            }
            else
            {
                Console.WriteLine($"Добро пожаловать, {userName}!");
                return userName;
            }
        }
    }
}