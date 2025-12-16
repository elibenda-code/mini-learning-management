using MiniLearningManagement.Api.DTOs;
using MiniLearningManagement.Api.Models;
using MiniLearningManagement.Api.Services.Interfaces;

public class EnrolmentService : IEnrolmentService
{
    private readonly List<Student> _students = new();
    private readonly List<Enrolment> _enrolments = new();
    private readonly ICourseService _courseService;

    public EnrolmentService(ICourseService courseService)
    {
        _courseService = courseService;
    }

    public Enrolment AssignStudent(string studentName, Guid courseId)
    {
        var courseExists = _courseService.GetAll().Any(c => c.Id == courseId);
        if (!courseExists)
            throw new KeyNotFoundException("Course not found");

        var student = new Student { FullName = studentName };
        _students.Add(student);

        var enrolment = new Enrolment
        {
            StudentId = student.Id,
            CourseId = courseId
        };

        _enrolments.Add(enrolment);
        return enrolment;
    }

    public IDictionary<Guid, int> GetStudentsCountPerCourse()
    {
        return _enrolments
            .GroupBy(e => e.CourseId)
            .ToDictionary(g => g.Key, g => g.Count());
    }

    public IEnumerable<CourseReportDto> GetReport()
    {
        var courses = _courseService.GetAll();

        return courses.Select(c => new CourseReportDto
        {
            CourseId = c.Id,
            CourseName = c.Name,
            StudentsCount = _enrolments.Count(e => e.CourseId == c.Id)
        });
    }

}
