using Microsoft.AspNetCore.Components;

namespace StudentManagementWebApp.Components.Pages
{
    public partial class StudentOverview
    {
        private List<Student> students = new();
        int count = StudentManager.students.Count;
        protected override void OnInitialized()
        {
            students = StudentManager.students;
        }
    }
}
