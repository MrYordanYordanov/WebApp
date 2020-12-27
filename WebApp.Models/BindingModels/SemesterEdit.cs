using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Models.BindingModels
{
    public class SemesterEdit
    {
        public string NameMessage { get; set; }

        public string StartDateMessage { get; set; }

        public string EndDateMessage { get; set; }

        public bool Error { get; set; }
    }
}
