using MiniLearningManagement.Api.Services.Interfaces;

public class MockStorageService : IStorageService
{
    public Task SaveAsync(string key, string content)
    {
        // Simulated AWS S3 save
        Console.WriteLine($"Mock save to S3: {key}");
        return Task.CompletedTask;
    }
}
