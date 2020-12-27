using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Models.BindingModels
{
    public class StudentEdit
    {
        public string NameMessage { get; set; }

        public string SurnameMessage { get; set; }

        public string DobMessage { get; set; }

        public bool Error { get; set; }
    }
}
