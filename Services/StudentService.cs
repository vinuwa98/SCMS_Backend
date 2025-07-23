using SCMS_Backend.Models;

public class StudentService : IStudentService
{
    private readonly IStudentRepository _studentRepository;

    public StudentService(IStudentRepository studentRepository)
    {
        _studentRepository = studentRepository;
    }

    public Task<IEnumerable<Student>> GetAllStudentsAsync() => _studentRepository.GetAllStudentsAsync();

    public Task<Student?> GetStudentByIdAsync(int id) => _studentRepository.GetStudentByIdAsync(id);

    public Task AddStudentAsync(Student student) => _studentRepository.AddStudentAsync(student);

    public Task UpdateStudentAsync(Student student) => _studentRepository.UpdateStudentAsync(student);

    public Task DeleteStudentAsync(int id) => _studentRepository.DeleteStudentAsync(id);
}
