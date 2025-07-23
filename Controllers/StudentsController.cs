using Microsoft.AspNetCore.Mvc;
using SCMS_Backend.Models;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    private readonly IStudentService _studentService;

    public StudentsController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllStudents()
    {
        var students = await _studentService.GetAllStudentsAsync();
        return Ok(students);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetStudent(int id)
    {
        var student = await _studentService.GetStudentByIdAsync(id);
        if (student == null) return NotFound();
        return Ok(student);
    }

    [HttpPost]
    public async Task<IActionResult> CreateStudent(Student student)
    {
        await _studentService.AddStudentAsync(student);
        return CreatedAtAction(nameof(GetStudent), new { id = student.StudentId }, student);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateStudent(int id, Student student)
    {
        student.StudentId = id; // force update
        await _studentService.UpdateStudentAsync(student);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteStudent(int id)
    {
        await _studentService.DeleteStudentAsync(id);
        return NoContent();
    }
}
