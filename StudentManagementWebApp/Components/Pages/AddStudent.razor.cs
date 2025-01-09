﻿
using Microsoft.AspNetCore.Components;

namespace StudentManagementWebApp.Components.Pages
{
    public partial class AddStudent
    {
        [SupplyParameterFromForm]
        public Student student { get; set; }

        protected string message=string.Empty;
        protected bool IsSaved =false;
        protected List<int> Marks { get; set; }
        private List<string> Subjects = StudentManager.Subjects;
        private Dictionary<string, int> SubjectMarks = new Dictionary<string, int>();

        

        protected override void OnInitialized()
        {
            foreach(var subject in StudentManager.Subjects)
            {
                SubjectMarks[subject] = 0;
            }
            student = new Student();
            Marks = new List<int>();    
        }

        private void HandleValidSubmit()
        {
            foreach(var mark in SubjectMarks.Values)
            {
                Marks.Add(mark);
            }
            student.Marks = Marks;
             StudentManager.students.Add(student);
            message = "The Student is added successfully";
            IsSaved = true;
        }
    }
}
