namespace StudentManagementWebApp.Contracts.Repositories
{
    public interface IStudentRepository
    {
        public Task<IEnumerable<Student>>GetStudents();
    }
}
