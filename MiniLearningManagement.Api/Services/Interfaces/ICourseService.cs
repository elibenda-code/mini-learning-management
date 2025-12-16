using MiniLearningManagement.Api.Models;

namespace MiniLearningManagement.Api.Services.Interfaces
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAll();
        Course Create(string name, string description);
        Course Update(Guid id, string name, string description);
    }
}
