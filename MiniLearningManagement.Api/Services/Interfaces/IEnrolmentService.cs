using MiniLearningManagement.Api.DTOs;
using MiniLearningManagement.Api.Models;

namespace MiniLearningManagement.Api.Services.Interfaces
{
    public interface IEnrolmentService
    {
        Enrolment AssignStudent(string studentName, Guid courseId);
        IDictionary<Guid, int> GetStudentsCountPerCourse();
        IEnumerable<CourseReportDto> GetReport();
    }
}
