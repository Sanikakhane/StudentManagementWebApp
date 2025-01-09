using Microsoft.AspNetCore.Components;

namespace StudentManagementWebApp.Components
{
    public partial class UpdateButton
    {
        [Parameter]
        public Student student {  get; set; }
        private void UpdateStudent()
        {
            StudentManager.updateStudent(student);
            NavigationManager.NavigateTo("/studentoverview");
            StateHasChanged();
        }
    }
}
