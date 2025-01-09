
using Microsoft.AspNetCore.Components;

namespace StudentManagementWebApp.Components.Pages
{
    public partial class AddStudent
    {
        [SupplyParameterFromForm]
        public Student student { get; set; }

        protected string message=string.Empty;
        protected bool IsSaved =false;
        protected override void OnInitialized()
        {
            student = new Student();
            Console.WriteLine(student.Id);
        }

        private void HandleValidSubmit()
        {
             StudentManager.students.Add(student);
            message = "The Student is added successfully";
            IsSaved = true;
        }
    }
}
