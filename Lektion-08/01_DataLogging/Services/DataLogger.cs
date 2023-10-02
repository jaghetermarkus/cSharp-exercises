using _01_DataLogging.Interfaces;

namespace _01_DataLogging.Services;

public class DataLogger : IDataLogger
{

    private readonly string _filePath;
    private readonly IFileManager _fileManager;

    public DataLogger(string filePath, IFileManager fileManager)
    {
        _filePath = filePath;
        _fileManager = fileManager;
    }

    public void Log(string message)
    {
        try
        {
        //var fileManager = new FileManager();
        _fileManager.SaveToFile(_filePath, message);
        }
        catch { }
    }
}

