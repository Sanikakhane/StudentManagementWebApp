using Microsoft.EntityFrameworkCore;
using StudentManagementWebApp.Data;
using StudentManagementWebApp.Contracts.Services;
using StudentManagementWebApp.Contracts.Repositories;

namespace StudentManagementWebApp.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

      

        public async Task<IEnumerable<Student>> GetAllStudents()
        {
            return await _studentRepository.GetStudents();
        }
    }
}
