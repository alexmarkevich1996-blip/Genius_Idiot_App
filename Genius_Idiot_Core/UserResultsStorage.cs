using Newtonsoft.Json;
using System.Reflection.Emit;

namespace Genius_Idiot_Core;

public class UserResultsStorage
{
    private readonly string resultsPath;
    public List<UserResult> Results { get; private set; }

    public UserResultsStorage()
    {
        resultsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "results.json");
        Results = new List<UserResult>();

        if (FileService.CheckFileContent(resultsPath))
        {
            Results = GetResults();
        }    
    }

    private void SaveResults(List<UserResult> results)
    {
        var jsonResults = JsonConvert.SerializeObject(results, Formatting.Indented);
        FileService.SaveDataInFile(resultsPath, jsonResults);
    }

    public void AppendResult(UserResult result)
    {
        Results.Add(result);
        SaveResults(Results);
    }

    public List<UserResult> GetResults()
    {
        var jsonResults = FileService.GetDataFromFile(resultsPath);

        var results = JsonConvert.DeserializeObject<List<UserResult>>(jsonResults);
        return results;
    }


}