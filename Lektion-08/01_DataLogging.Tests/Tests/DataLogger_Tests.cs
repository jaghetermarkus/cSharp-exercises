using _01_DataLogging.Interfaces;
using _01_DataLogging.Services;
using Moq;

namespace _01_DataLogging.Tests.Tests;

public class DataLogger_Tests
{
    private readonly string _realFilePath = @$"{Guid.NewGuid()}.txt";
    private readonly string _fakeFilePath = @$"c:\{Guid.NewGuid()}\fakefile.txt";
    private readonly string _content = "Testing";

    [Fact]
    public void Log_Should_LogMessageToLogFile()
    {
        // Arrange
        var mockFileManager = new Mock<IFileManager>();
        IDataLogger dataLogger = new DataLogger(@"testing-mock.txt", mockFileManager.Object); // sut = System Under Test, dvs det vi vill testa. Alternativ att döpa till istället för dataLogger i detta fall om man föredrar det. 


        // Act
        dataLogger.Log(_content);


        // Assert
        mockFileManager.Verify(x => x.SaveToFile(@"testing-mock.txt", _content), Times.Once);



    }

}

