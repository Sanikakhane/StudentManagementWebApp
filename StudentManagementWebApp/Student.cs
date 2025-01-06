

namespace StudentManagementWebApp
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public int Marks { get; set; }

        public Student(int id, string? name, int age, int marks)
        {
            Id = id;
            Name = name;
            Age = age;
            Marks = marks;
        }
        public static List<Student> GetList()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1,"Sanika",21,97));
            students.Add(new Student(2, "abc", 22, 96));
            students.Add(new Student(3, "abc", 78, 95));
            students.Add(new Student(4, "abc", 32, 90));

            return students;
        }
    }
}
