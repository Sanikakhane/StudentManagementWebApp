namespace StudentManagementWebApp.Components.Pages
{
    public partial class StudentOverview
    {
        private List<Student> students { get; set; } = default!;
        private int count;

        protected override void OnInitialized()
        {
            students = StudentManager.GetList();
            count = students.Count;
        }
    }
}
