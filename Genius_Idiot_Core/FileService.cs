using Newtonsoft.Json;
using System.ComponentModel;
using System.Text;
using System.Text.Json.Nodes;

namespace Genius_Idiot_Core;

public static class FileService
{

    public static bool CheckFileContent(string filePath)
    {
        return File.Exists(filePath) && new FileInfo(filePath).Length > 0;
    }

    public static string? GetDataFromFile(string filePath)
    {
        if (FileService.CheckFileContent(filePath))
            return null;

        var fileContent = File.ReadAllText(filePath);
        return fileContent;
    }

    public static void SaveDataInFile(string filePath, string jsonData)
    {
        File.WriteAllText(filePath, jsonData, Encoding.UTF8);
    }
}