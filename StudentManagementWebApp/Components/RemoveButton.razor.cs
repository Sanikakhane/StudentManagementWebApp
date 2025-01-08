using Microsoft.AspNetCore.Components;

namespace StudentManagementWebApp.Components
{
    public partial class RemoveButton
    {
        [Parameter]
        public Student student { get; set; }    
        private void RemoveStudent()
        {
            Console.WriteLine(student.Name);
            Student studentToRemove = StudentManager.students.FirstOrDefault(s => s.Id == student.Id);
            if (studentToRemove != null)
            {
                StudentManager.students.ToList().Remove(studentToRemove);
            }
            
            NavigationManager.NavigateTo("/studentoverview");
            StateHasChanged();
        }
    }
}
