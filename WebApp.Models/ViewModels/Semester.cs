using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Models.ViewModels
{
    public class Semester
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string StartDate { get; set; }

        public string EndDate { get; set; }
    }
}
