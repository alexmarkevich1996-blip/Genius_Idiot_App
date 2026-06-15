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
        if (CheckFileContent(filePath))
        {
            var fileContent = File.ReadAllText(filePath);
            return fileContent;
        }
        else 
        {
            throw new Exception("File is empty");
        }
        
    }

    public static void SaveDataInFile(string filePath, string jsonData)
    {
        File.WriteAllText(filePath, jsonData, Encoding.UTF8);
    }
}