using Microsoft.AspNetCore.Mvc;
using MiniLearningManagement.Api.DTOs;
using MiniLearningManagement.Api.Services.Interfaces;

namespace MiniLearningManagement.Api.Controllers
{
    [ApiController]
    [Route("api/courses")]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_courseService.GetAll());
        }
        [HttpPost]
        public IActionResult Create([FromBody] CourseDto dto)
        {
            var course = _courseService.Create(dto.Name, dto.Description);
            return Ok(course);
        }

        [HttpPut("{id}")]
        public IActionResult Update(Guid id, [FromBody] CourseDto dto)
        {
            var course = _courseService.Update(id, dto.Name, dto.Description);

            return Ok(new CourseDto
            {
                Id = course.Id,
                Name = course.Name,
                Description = course.Description
            });
        }
    }
}
