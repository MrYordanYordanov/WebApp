using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Models.ViewModels
{
    public class SemesterDisciplies
    {
        public Semester Semester { get; set; }

        public List<Discipline> Disciplines { get; set; }
    }
}
