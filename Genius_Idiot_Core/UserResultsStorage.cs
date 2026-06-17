using Newtonsoft.Json;
using System.Reflection.Emit;

namespace Genius_Idiot_Core;

public class UserResultsStorage
{
    private readonly string resultsPath;
    private static IConvert converter = new XMLConverter();
    public List<UserResult> Results { get; private set; }

    public UserResultsStorage()
    {
        resultsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "results");
        Results = new List<UserResult>();

        if (FileService.CheckFileContent(resultsPath))
        {
            Results = GetResults();
        }    
    }

    private void SaveResults(List<UserResult> results)
    {
        var jsonResults = converter.Serialize(results);
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

        var results = converter.Deserialize<List<UserResult>>(jsonResults);
        return results;
    }


}