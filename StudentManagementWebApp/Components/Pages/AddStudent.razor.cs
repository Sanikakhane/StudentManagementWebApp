
using Microsoft.AspNetCore.Components;

namespace StudentManagementWebApp.Components.Pages
{
    public partial class AddStudent
    {
        [SupplyParameterFromForm]
        public Student? student { get; set; }

        protected string message=string.Empty;
        protected bool IsSaved =false;
        protected List<int>? Marks { get; set; }
        private List<string> Subjects = StudentManager.Subjects;
        private Dictionary<string, int> SubjectMarks = new Dictionary<string, int>();

        private Student st;
        private int id;


        protected override void OnInitialized()
        {

            foreach(var subject in StudentManager.Subjects)
            {
                SubjectMarks[subject] = 0;
            }
            student = new Student()!;
            Marks = new List<int>();
            st = StudentManager.students.LastOrDefault();
            id = st != null ? st.Id + 1 : 1; 
            student.Id = id;

        }

        private void HandleValidSubmit()
        {
            bool hasInvalidMarks = SubjectMarks.Values.Any(mark => mark < 0);
            if (hasInvalidMarks)
            {
                message = "Marks cannot be negative.";
                return;
            }

            Marks = SubjectMarks.Values.ToList();
            student.Marks = Marks;

            StudentManager.students.Add(student);
            message = "The Student is added successfully.";
            IsSaved = true;
        }

    }
}
