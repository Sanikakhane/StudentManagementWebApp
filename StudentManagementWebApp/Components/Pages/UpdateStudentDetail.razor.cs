using Microsoft.AspNetCore.Components;

namespace StudentManagementWebApp.Components.Pages
{
    public partial class UpdateStudentDetail
    {
        [Parameter]
        public int Id { get; set; }

        [SupplyParameterFromForm]
        public Student student { get; set; }

        protected string message = string.Empty;
        protected bool IsSaved = false;
        protected List<int> Marks { get; set; }
        private List<string> Subjects = StudentManager.Subjects;
        private Dictionary<string, int> SubjectMarks = new Dictionary<string, int>();



        protected override void OnInitialized()
        {
            foreach (var subject in StudentManager.Subjects)
            {
                SubjectMarks[subject] = 0;
            }
            student = StudentManager.students.First(st => st.Id == Id);
            Marks = new List<int>();
        }
        
        protected void HandleValidUpdate()
        {
            foreach (var mark in SubjectMarks.Values)
            {
                Marks.Add(mark);
            }
            student.Marks = Marks;
            StudentManager.updateStudent(student);
            message = "The Student is Updated successfully";
            IsSaved = true;
        }
    }
}
