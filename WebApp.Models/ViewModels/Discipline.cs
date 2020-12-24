using System;
using System.Collections.Generic;
using System.Text;

namespace WebApp.Models.ViewModels
{
    public class Discipline
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string ProfessorName { get; set; }

        public decimal Score { get; set; }
    }
}
