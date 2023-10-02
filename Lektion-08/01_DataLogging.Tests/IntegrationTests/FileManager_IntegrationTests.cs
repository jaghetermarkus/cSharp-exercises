using _01_DataLogging.Interfaces;
using _01_DataLogging.Services;

namespace _01_DataLogging.Tests.IntegrationTests;

public class FileManager_IntegrationTests
{
    [Fact]
    public void SaveToFile_Should_WriteContentToFileWhenFileExists_ThenReturnTrue()
    {
        // Arrange
        IFileManager fileManager = new FileManager();
        string filePath = $"{Guid.NewGuid()}.txt";

        // Act
        bool result = fileManager.SaveToFile(filePath, "Testing");

        // Assert
        Assert.True(result);

        //Cleanup
        if (File.Exists(filePath))
            File.Delete(filePath);

    }

}

