

using System.ComponentModel.DataAnnotations;

namespace StudentManagementWebApp
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public int Age { get; set; }
        public List<int> Marks { get; set; }

        public Student() { }    
        public Student(int id, string? name, int age, List<int> marks)
        {
            Id = id;
            Name = name;
            Age = age;
            Marks = marks;
        }
        
    }
}
