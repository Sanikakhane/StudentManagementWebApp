using Microsoft.EntityFrameworkCore;
using StudentManagementWebApp.Contracts.Repositories;
using StudentManagementWebApp.Data;

namespace StudentManagementWebApp.Repositories
{
    public class StudentRepository : IStudentRepository,IDisposable
    {
        private readonly AppDbContext appDbContext;

        public StudentRepository(IDbContextFactory<AppDbContext> DbFactory) 
        {
            appDbContext = DbFactory.CreateDbContext();
        }
        public void Dispose()
        {
            appDbContext.Dispose();
        }
        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await appDbContext.Students.ToListAsync();
        }
    }
}
