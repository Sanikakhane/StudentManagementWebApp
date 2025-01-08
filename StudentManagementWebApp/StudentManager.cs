using StudentManagementWebApp.Services;
using StudentManagementWebApp.Contracts.Services;
namespace StudentManagementWebApp
{
    public class StudentManager
    {
        private  readonly StudentService? _studentService;

        public static IEnumerable<Student> students = new List<Student>();
       
        //public StudentManager(IStudentService? studentService)
        //{
        //    _studentService = studentService;
        //}

        public async static Task< IEnumerable<Student> > GetList()
        {
            StudentService studentService = new StudentService();
            students = await studentService.GetAllStudents();
            return students;
        }
        //public static List<int> GetMarksById(int id)
        //{

        //    Student student = students.FirstOrDefault(s => s.Id == id);

        //    return student?.Marks ?? new List<int>();
        //}
        //public List<Student> GetStudents()
        //{
        //    return _studentService.GetAllStudents();
        //}
        //public async Task SaveStudentAsync(Student student)
        //{
        //    var existingStudent = students.SingleOrDefault(s => s.Id == student.Id);
        //    if (existingStudent != null)
        //    {
        //        existingStudent.Name = student.Name;
        //        existingStudent.Age = student.Age;
        //        existingStudent.Marks = student.Marks;
        //    }
        //    else
        //    {
        //        students.Add(student);
        //    }

        //    await Task.CompletedTask;
        //}
    }
}
