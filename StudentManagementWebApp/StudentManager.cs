namespace StudentManagementWebApp
{
    public class StudentManager
    {
        public static List<Student> students = new List<Student>()
        {
                new Student(1, "John", 20, new List<int> { 85, 90, 78 }),
                new Student(2, "Alice", 22, new List<int> { 92, 88, 94 }),
                new Student(3, "Bob", 21, new List<int> { 75, 80, 70 }),
                new Student(4, "Charlie", 23, new List<int> { 65, 70, 80 }),
                new Student(5, "David", 24, new List<int> { 88, 90, 85 }),
                new Student(6, "Eve", 19, new List<int> { 78, 82, 80 }),
                new Student(7, "Frank", 20, new List<int> { 92, 95, 91 }),
                new Student(8, "Grace", 22, new List<int> { 70, 72, 68 }),
                new Student(9, "Hannah", 21, new List<int> { 90, 88, 85 }),
                new Student(10, "Ivy", 23, new List<int> { 80, 85, 78 })
         };

        public static List<int> GetMarksById(int id)
        {

            Student student = students.FirstOrDefault(s => s.Id == id);

            return student?.Marks ?? new List<int>();
        }
        public static void removeStudent(int id)
        {
            Student studentToRemove = students.FirstOrDefault(s => s.Id == id);
            if (studentToRemove != null)
            {
                students.Remove(studentToRemove);
            }
        }

        public static void updateStudent(Student student)
        {
            Student studentToUpdate = students.SingleOrDefault(s => s.Id == student.Id);

            if (studentToUpdate != null)
            {
                studentToUpdate.Name = student.Name;
                studentToUpdate.Age = student.Age;
                studentToUpdate.Marks = student.Marks;
            }

        }
    }
}
