using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using WebApp.Models.BindingModels;
using WebApp.Models.ViewModels;

namespace WebApp.Validation.Disciplines
{
    public class DisciplinesValidation
    {
        public List<string> ValidateDisciplines(Discipline disicpiline)
        {
            var messages = new List<string>();
            Regex namergx = new Regex(@"^[A-Z].+$");
            Regex prnamergx = new Regex(@"^[A-Z]+[a-z]+([\s.]*[A-Z]+[a-z]+)*$");

            if (string.IsNullOrEmpty(disicpiline.Name) || string.IsNullOrWhiteSpace(disicpiline.Name))
            {
                messages.Add("<span class=\"text-danger\">Name is required</span>" +
                    "<span>       </span>");
            }
            else
            {
                if (!namergx.IsMatch(disicpiline.Name))
                {
                    messages.Add("<span class=\"text-danger\">Name must starts with uppercase " +
                        "and contains at least 2 letters</span><span>       </span>");
                }
            }

            if (string.IsNullOrEmpty(disicpiline.ProfessorName) || string.IsNullOrWhiteSpace(disicpiline.ProfessorName))
            {
                messages.Add("<span class=\"text-danger\">Proffesor Name is required</span>" +
                    "<span>       </span>");
            }
            else
            {
                if (!prnamergx.IsMatch(disicpiline.ProfessorName))
                {
                    messages.Add("<span class=\"text-danger\">Proffesor Name must starts with uppercase follow with lowercase" +
                        " letter and contains at least 2 letters</span><span>       </span>");
                }
            }
            if (disicpiline.Score < 0)
            {
                messages.Add("<span class=\"text-danger\">Score must be a positive number</span><span>       </span>");
            }
            

            return messages;

        }

        public DisciplineEdit ValidateEditDiscipline(Discipline disicpiline)
        {
            var model = new DisciplineEdit();
            Regex namergx = new Regex(@"^[A-Z].+$");
            Regex prnamergx = new Regex(@"^[A-Z]+[a-z]+([\s.]*[A-Z]+[a-z]+)*$");

            if (string.IsNullOrEmpty(disicpiline.Name) || string.IsNullOrWhiteSpace(disicpiline.Name))
            {
                model.NameMessage = "Name is required";
                model.Error = true;
            }
            else
            {
                if (!namergx.IsMatch(disicpiline.Name))
                {
                    model.NameMessage = "Name must starts with uppercase " +
                        "and contains at least 2 letters";
                    model.Error = true;
                }
            }

            if (string.IsNullOrEmpty(disicpiline.ProfessorName) || string.IsNullOrWhiteSpace(disicpiline.ProfessorName))
            {
                model.PrNameMessage = "Proffesor Name is required";
                model.Error = true;
            }
            else
            {
                if (!prnamergx.IsMatch(disicpiline.ProfessorName))
                {
                    model.PrNameMessage = "Proffesor Name must starts with uppercase follow with lowercase" +
                        " letter and contains at least 2 letters";
                    model.Error = true;
                }
            }
            if (disicpiline.Score < 0)
            {
                model.ScoreMessage = "Score must be a positive number";
                model.Error = true;
            }

            return model;
        }
    }
}
