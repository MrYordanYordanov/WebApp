using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using WebApp.Models.BindingModels;
using WebApp.Models.ViewModels;

namespace WebApp.Validation.Students
{
    public class StudentsValidation
    {
        public List<string> ValidateStudent(Student student)
        {
            var messages = new List<string>();
            Regex rgx = new Regex(@"^[A-Z][a-z]+$");

            if (string.IsNullOrEmpty(student.Name) || string.IsNullOrWhiteSpace(student.Name))
            {
                messages.Add("<span class=\"text-danger\">Name is required</span>" +
                    "<span>       </span>");
            }
            else
            {
                if (!rgx.IsMatch(student.Name))
                {
                    messages.Add("<span class=\"text-danger\">Name must starts with uppercase follow with lowercase" +
                        "and contains at least 2 letters</span><span>       </span>");
                }
            }
            if (string.IsNullOrEmpty(student.Surname) || string.IsNullOrWhiteSpace(student.Surname))
            {
                messages.Add("<span class=\"text-danger\">Surname is required</span>" +
                    "<span>       </span>");
            }
            else
            {
                if (!rgx.IsMatch(student.Surname))
                {
                    messages.Add("<span class=\"text-danger\">Surname must starts with uppercase follow with lowercase" +
                        "and contains at least 2 letters</span>" +
                        "<span>       </span>");
                }
            }

            if (string.IsNullOrEmpty(student.Dob) || string.IsNullOrWhiteSpace(student.Dob))
            {
                messages.Add("<span class=\"text-danger\">DOB is required<span>" +
                    "<span>       </span>");
            }
            else
            {
                try
                {
                    var dateTime = DateTime.Parse(student.Dob);
                }
                catch
                {
                    messages.Add("<span class=\"text-danger\">Invalid DOB</span>");
                }
            }

            return messages;
        }

        public StudentEdit ValidateEditStudent(Student student)
        {
            var model = new StudentEdit();
            Regex rgx = new Regex(@"^[A-Z][a-z]+$");

            if (string.IsNullOrEmpty(student.Name) || string.IsNullOrWhiteSpace(student.Name))
            {
                model.NameMessage="Name is required";
                model.Error = true;
            }
            else
            {
                if (!rgx.IsMatch(student.Name))
                {
                    model.NameMessage = "Name must starts with uppercase follow with lowercase" +
                        "and contains at least 2 letters";
                    model.Error = true;
                }
            }
            if (string.IsNullOrEmpty(student.Surname) || string.IsNullOrWhiteSpace(student.Surname))
            {
                model.SurnameMessage = "Surname is required";
                model.Error = true;
            }
            else
            {
                if (!rgx.IsMatch(student.Surname))
                {
                    model.SurnameMessage = "Surname must starts with uppercase follow with lowercase" +
                        "and contains at least 2 letters";
                    model.Error = true;
                }
            }

            if (string.IsNullOrEmpty(student.Dob) || string.IsNullOrWhiteSpace(student.Dob))
            {
                model.DobMessage = "DOB is required";
                model.Error = true;
            }
            else
            {
                try
                {
                    var dateTime = DateTime.Parse(student.Dob);
                }
                catch
                {
                    model.DobMessage = "Invalid DOB";
                    model.Error = true;
                }
            }

            return model;
        }
    }
}
