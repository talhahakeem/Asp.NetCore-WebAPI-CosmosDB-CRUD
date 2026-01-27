using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentAdminPortal.Data;
using StudentAdminPortal.Models;
using StudentAdminPortal.Models.Entities;

namespace StudentAdminPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext dbContext;

        public StudentsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStudents()
        {
            // Cosmos DB operations should be async
            var students = await dbContext.Students.ToListAsync();
            return Ok(students);
        }

        [HttpGet]
        [Route("{id:guid}")]
        public async Task<IActionResult> GetStudentById(Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);
            if (student is null)
            {
                return NotFound();
            }
            return Ok(student);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent(AddStudentDto addStudentDto)
        {
            var studentEntity = new Student()
            {
                Id = Guid.NewGuid(), // Manually generate ID for Cosmos
                Name = addStudentDto.Name,
                Email = addStudentDto.Email,
                Phone = addStudentDto.Phone,
                Fees = addStudentDto.Fees
            };

            await dbContext.Students.AddAsync(studentEntity);
            await dbContext.SaveChangesAsync();
            return Ok(studentEntity);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateStudent(Guid id, UpdateStudentDto updateStudentDto)
        {
            var student = await dbContext.Students.FindAsync(id);
            if (student is null)
            {
                return NotFound();
            }

            student.Name = updateStudentDto.Name;
            student.Email = updateStudentDto.Email;
            student.Phone = updateStudentDto.Phone;
            student.Fees = updateStudentDto.Fees;

            await dbContext.SaveChangesAsync();
            return Ok(student);
        }

        [HttpDelete]
        [Route("{id:guid}")]
        public async Task<IActionResult> DeleteStudent(Guid id)
        {
            var student = await dbContext.Students.FindAsync(id);
            if (student is null)
            {
                return NotFound();
            }

            dbContext.Students.Remove(student);
            await dbContext.SaveChangesAsync();
            return Ok();
        }
    }
}