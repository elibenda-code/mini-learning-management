namespace MiniLearningManagement.Api.DTOs
{
    public class CourseReportDto
    {
        public Guid CourseId { get; set; }
        public string CourseName { get; set; } = string.Empty;
        public int StudentsCount { get; set; }
    }
}
