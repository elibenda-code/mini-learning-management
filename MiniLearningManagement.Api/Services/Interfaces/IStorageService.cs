namespace MiniLearningManagement.Api.Services.Interfaces
{
    public interface IStorageService
    {
        Task SaveAsync(string key, string content);
    }
}
