

namespace StudentManagementWebApp
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public List<int> Marks { get; set; }

        public Student(int id, string? name, int age, List<int> marks)
        {
            Id = id;
            Name = name;
            Age = age;
            Marks = marks;
        }
        
    }
}
