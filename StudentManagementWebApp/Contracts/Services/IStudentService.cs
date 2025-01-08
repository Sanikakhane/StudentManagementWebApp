namespace StudentManagementWebApp.Contracts.Services
{
    public interface IStudentService
    {
        public  Task<IEnumerable<Student>> GetAllStudents();
    }
}
