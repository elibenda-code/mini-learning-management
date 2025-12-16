using MiniLearningManagement.Api.Services;
using Xunit;

namespace MiniLearningManagement.Tests
{
    public class CourseServiceTests
    {
        [Fact]
        public void Create_ShouldAddCourse()
        {
            var service = new CourseService();

            var course = service.Create("Math", "Basic mathematics");

            Assert.NotNull(course);
            Assert.Equal("Math", course.Name);
            Assert.Equal("Basic mathematics", course.Description);
        }
    }
}
