using Newtonsoft.Json;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Nodes;

namespace Genius_Idiot_Core;

public class FileService
{
    private readonly string resultsPath;
    private readonly string questionsPath;
    
    public FileService()
    {
        var baseDir = AppDomain.CurrentDomain.BaseDirectory;
        var dataDir = Path.Combine(baseDir, "Data");
        Directory.CreateDirectory(dataDir);
        questionsPath = Path.Combine(dataDir, "questions.txt");
        resultsPath = Path.Combine(dataDir, "results.json");



        var hasFileQuestions = File.Exists(questionsPath) && new FileInfo(questionsPath).Length > 0;
        if (!hasFileQuestions)
        {
            var questionsList = new List<Question>()
            {
                new Question("Сколько будет два плюс два умноженное на два?", 6),
                new Question("Бревно нужно распилить на 10 частей, сколько надо сделать распилов?", 9),
                new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25),
                new Question("Укол делают каждые полчаса, сколько нужно минут для трех уколов?", 60),
                new Question("Пять свечей горело, две потухли. Сколько свечей осталось?",5)
            };
            SaveQuestions(questionsList);
        }
    }
    public void SaveResults(List<UserResult> results)
    {
        var jsonData = JsonConvert.SerializeObject(results, Formatting.Indented);
        File.WriteAllText(resultsPath, jsonData, Encoding.UTF8);
    }

    public void AppendResult(UserResult userResult)
    {
        var allResults = GetPreviousResults();
        allResults.Add(userResult);
        SaveResults(allResults);
    }

    public List<UserResult> GetPreviousResults()
    {
        if (!File.Exists(resultsPath))
        {
            return new List<UserResult>();
        }

        var fileContent = File.ReadAllText(resultsPath);
        var userResults = JsonConvert.DeserializeObject<List<UserResult>>(fileContent);

        return userResults;
    }

    public List<Question> GetQuestionsFromFile()
    {
        var fileContent = File.ReadAllText(questionsPath);
        var questions = JsonConvert.DeserializeObject<List<Question>>(fileContent);

        return questions;
    }
    

    public void AddQuestionInFile(Question question)
    {
        var questions = GetQuestionsFromFile();
        questions.Add(question);
        SaveQuestions(questions);
    }

    public void SaveQuestions(List<Question> questions)
    {
        var jsonData = JsonConvert.SerializeObject(questions, Formatting.Indented);
        File.WriteAllText(questionsPath, jsonData, Encoding.UTF8);
    }
    public void RemoveQuestionFromFile(int index)
    {
        var question = GetQuestionsFromFile();
        question.RemoveAt(index);
        SaveQuestions(question);
    }
}