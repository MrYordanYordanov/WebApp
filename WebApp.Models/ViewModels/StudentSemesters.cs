using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Models.ViewModels
{
    public class StudentSemesters
    {
        public Student Student { get; set; }

        public List<Semester> Semesters { get; set; }

        public List<Semester> AvailableSemesters { get; set; }

        public StudentSemesters()
        {
            this.Student = new Student();
            this.Semesters = new List<Semester>();
            this.AvailableSemesters = new List<Semester>();
        }
    }
}
