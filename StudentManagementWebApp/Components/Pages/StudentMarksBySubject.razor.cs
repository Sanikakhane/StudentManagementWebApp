using Microsoft.AspNetCore.Components;

namespace StudentManagementWebApp.Components.Pages
{
    public partial class StudentMarksBySubject
    {
        [Parameter]
        public int Id { get; set; }

        public Student? Student { get; set; } = default!;
        public List<int>? Marks { get; set; } = default!;
        public List<string> Subjects { get; set; } = new List<string>
        {
            "Mathematics",
            "Science",
            "History"
        };

        
        protected override  void OnInitialized()
        {
                var students = StudentManager.students;
                Student = students.SingleOrDefault(s => s.Id == Id);
                Marks = StudentManager.GetMarksById(Id);

        }
        
    }
}
