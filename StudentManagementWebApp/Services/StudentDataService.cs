using Microsoft.EntityFrameworkCore;
using StudentManagementWebApp.Data;

namespace StudentManagementWebApp.Services
{
    public class StudentDataService
    {
        private readonly AppDbContext _dbContext;

        public StudentDataService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Student>> GetAllStudents()
        {
            var students = await _dbContext.Students.AsNoTracking().ToListAsync();
            if (students == null || students.Count == 0)
            {
                Console.WriteLine("The List is empty");
            }
            return students ?? new List<Student>(); 
        }
    }
}
