using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentPerformance.Business.Contract;
using StudentPerformance.Entity.Models;
using StudentPerformance.ViewModels.ViewModels;

namespace StudentPerformanceData.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentPerformanceController : ControllerBase
    {
        /* private readonly SperformanceContext _context;
         private readonly IMapper _mapper;

         public StudentPerformanceController(SperformanceContext context, IMapper mapper)
         {
             _context = context;
             _mapper = mapper;
         }*/
        public readonly IStudentPerformanceBusiness _studentPerformanceBusiness;
        public StudentPerformanceController(IStudentPerformanceBusiness studentPerformanceBusiness)
        {
            _studentPerformanceBusiness = studentPerformanceBusiness;
        }
        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var students = await _studentPerformanceBusiness.GetStudents();
            return Ok(students);
        }
        [HttpGet("{studentId}")]
        public async Task<IActionResult> GetStudentById(int studentId)
        {
            var student = await _studentPerformanceBusiness.GetStudentById(studentId);
            if (student == null)
                return NotFound();
            return Ok(student);
        }
        [HttpPut("{sId}")]
        public async Task<IActionResult> UpdateStudent(int studentId, StudentModel student)
        {
            if (studentId != student.StudentId)
                return BadRequest();

            await _studentPerformanceBusiness.UpdateStudent(student);
            return Ok();
        }

    }
}
