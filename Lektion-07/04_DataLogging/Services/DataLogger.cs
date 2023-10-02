using _04_DataLogging.Interfaces;

namespace _04_DataLogging.Services;

public class DataLogger : IDataLogger
{

    private readonly string _filePath;
    private readonly IFileHandler _fileHandler;

    public DataLogger(string filePath, IFileHandler fileHandler)
    {
        _filePath = filePath;
        _fileHandler = fileHandler;
    }

    public IEnumerable<string> Messages()
    {
        return _fileHandler.ReadFromFile(_filePath);
    }


    public void LogMessage(string message)
    {
        throw new NotImplementedException();
    }


    public void Run()
    {
        throw new NotImplementedException();
    }
}

