using MiniLearningManagement.Api.Models;
using MiniLearningManagement.Api.Services.Interfaces;

namespace MiniLearningManagement.Api.Services
{
    public class CourseService : ICourseService
    {
        private readonly List<Course> _courses = new();

        public IEnumerable<Course> GetAll()
        {
            return _courses;
        }

        public Course Create(string name, string description)
        {
            var course = new Course
            {
                Name = name,
                Description = description
            };

            _courses.Add(course);
            return course;
        }
        public Course Update(Guid id, string name, string description)
        {
            var course = _courses.FirstOrDefault(c => c.Id == id)
                ?? throw new KeyNotFoundException("Course not found");

            course.Name = name;
            course.Description = description;

            return course;
        }
    }
}
