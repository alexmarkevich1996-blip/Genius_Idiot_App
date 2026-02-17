using System.Text;

namespace Genius_Idiot_Console_App;

public class FileService
{
    private readonly string userResultsFilePath;
    private readonly string questionsListFilePath;
    private StreamWriter ResultsWriter;
    private StreamReader ResultsReader;
    
    public FileService()
    {
        userResultsFilePath = "/Users/aleksandr/RiderProjects/Genius_Idiot_App/Genius_Idiot_Console_App/user_results.txt";
        ResultsWriter = new StreamWriter(userResultsFilePath, true, Encoding.UTF8);
        ResultsReader = new StreamReader(userResultsFilePath, Encoding.UTF8);
        
        questionsListFilePath = "/Users/aleksandr/RiderProjects/Genius_Idiot_App/Genius_Idiot_Console_App/questions.txt";
        
    }

    public void SaveResultsInFile(User user, UserResultsStorage results)
    {
        var lastResult = results.Results.Last();
        ResultsWriter.WriteLine($"{user.Name}-{lastResult.Score}-{lastResult.Level}-{lastResult.Date}");
        ResultsWriter.Close();
    }
    
    public void ShowPreviousResults()
    {
        Console.WriteLine("Хотите просмотреть предыдущие результат? Введите \"ДА\" для продолжения: ");
        string answer = Console.ReadLine().ToLower();

        if (answer.ToLower() != "да")
            return; 
        
        Console.WriteLine("{0,-20}{1,18}{2,15}{3,15}", "Имя","Кол-во правильных ответов","Результат","Дата");
        while (!ResultsReader.EndOfStream)
        {
            string line = ResultsReader.ReadLine();
            string[] lineParts = line.Split('-');
            string userName = lineParts[0];
            string finalScore = lineParts[1];
            string level = lineParts[2];
            string date = lineParts[3];
            Console.WriteLine("{0,-20}{1,15}{2,23}{3,32}", userName, finalScore, level, date);
        }
        ResultsReader.Close();
    }
}