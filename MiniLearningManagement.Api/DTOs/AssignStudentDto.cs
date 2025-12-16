namespace MiniLearningManagement.Api.DTOs
{
    public class AssignStudentDto
    {
        public string StudentName { get; set; } = string.Empty;
        public Guid CourseId { get; set; }
    }
}
