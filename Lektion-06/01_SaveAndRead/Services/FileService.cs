namespace _01_SaveAndRead.Services;

public class FileService
{

    private static readonly string filePath = @"/Users/markuskarlsson/nackademin/csharp/exercises/Lektion-06/users.json";

    public static void SaveToFile(string contentAsJson)
    {
        using var sw = new StreamWriter(filePath);
        sw.WriteLine(contentAsJson);
    }

    public static string ReadFromFile()
    {
        if (File.Exists(filePath))
        {
        using var sr = new StreamReader(filePath);
        return sr.ReadToEnd();
        }

        return null!;
    }
}

