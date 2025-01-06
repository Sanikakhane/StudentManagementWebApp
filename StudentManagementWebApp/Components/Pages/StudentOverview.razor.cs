namespace StudentManagementWebApp.Components.Pages
{
    public partial class StudentOverview
    {
        private List<Student> students { get; set; } = default!;
        private int count;

        protected async override Task OnInitializedAsync()
        {
            await Task.Delay(2000);
            students = Student.GetList();
            count = students.Count;
        }
    }
}
