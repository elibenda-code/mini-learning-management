using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniLearningManagement.Api.DTOs;
using MiniLearningManagement.Api.Services.Interfaces;

namespace MiniLearningManagement.Api.Controllers
{
    [ApiController]
    [Route("api/enrolments")]
    public class EnrolmentsController : ControllerBase
    {
        private readonly IEnrolmentService _enrolmentService;

        public EnrolmentsController(IEnrolmentService enrolmentService)
        {
            _enrolmentService = enrolmentService;
        }

        [HttpPost]
        public IActionResult AssignStudent([FromBody] AssignStudentDto dto)
        {
            var enrolment = _enrolmentService.AssignStudent(dto.StudentName, dto.CourseId);

            if (enrolment == null)
                return NotFound("Course not found");

            return Ok(enrolment);
        }

        [HttpGet("report")]
        public IActionResult GetReport()
        {
            var report = _enrolmentService.GetReport();
            return Ok(report);
        }
    }
}
