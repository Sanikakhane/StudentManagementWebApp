using System.ComponentModel.DataAnnotations;

namespace StudentManagementWebApp
{
    public class Student
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "Student name is required.")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(1, 100, ErrorMessage = "Age must be between 1 and 100.")]
        public int Age { get; set; }

       
        public List<int> Marks { get; set; } = new List<int>();

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
