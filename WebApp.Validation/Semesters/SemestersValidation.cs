using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using WebApp.Models.BindingModels;
using WebApp.Models.ViewModels;

namespace WebApp.Validation.Semesters
{
    public class SemestersValidation
    {
        public List<string> ValidateSemester(Semester semester)
        {
            var messages = new List<string>();
            Regex rgx = new Regex(@"[A-Z]+[a-z0-9 ]+$");

            if (string.IsNullOrEmpty(semester.Name) || string.IsNullOrWhiteSpace(semester.Name))
            {
                messages.Add("<span class=\"text-danger\">Name is required</span>" +
                    "<span>       </span>");
            }
            else
            {
                if (!rgx.IsMatch(semester.Name))
                {
                    messages.Add("<span class=\"text-danger\">Name must starts with uppercase " +
                        "and contains at least 2 letters</span><span>       </span>");
                }
            }
            if (string.IsNullOrEmpty(semester.StartDate) || string.IsNullOrWhiteSpace(semester.StartDate))
            {
                messages.Add("<span class=\"text-danger\">Start date is required<span>" +
                    "<span>       </span>");
            }
            else
            {
                try
                {
                    var dateTime = DateTime.Parse(semester.StartDate);
                }
                catch
                {
                    messages.Add("<span class=\"text-danger\">Invalid start date</span>");
                }
            }
            if (string.IsNullOrEmpty(semester.EndDate) || string.IsNullOrWhiteSpace(semester.EndDate))
            {
                messages.Add("<span class=\"text-danger\">End date is required<span>" +
                    "<span>       </span>");
            }
            else
            {
                try
                {
                    var dateTime = DateTime.Parse(semester.EndDate);
                }
                catch
                {
                    messages.Add("<span class=\"text-danger\">Invalid end date</span>");
                }
            }

            return messages;
        }

        public SemesterEdit ValidateEditSemester(Semester semester)
        {
            var model = new SemesterEdit();
            Regex rgx = new Regex(@"[A-Z]+[a-z0-9 ]+$");

            if (string.IsNullOrEmpty(semester.Name) || string.IsNullOrWhiteSpace(semester.Name))
            {
                model.NameMessage = "Name is required";
                model.Error = true;
            }
            else
            {
                if (!rgx.IsMatch(semester.Name))
                {
                    model.NameMessage = "Name must starts with uppercase " +
                        "and contains at least 2 letters";
                    model.Error = true;
                }
            }
            if (string.IsNullOrEmpty(semester.StartDate) || string.IsNullOrWhiteSpace(semester.StartDate))
            {
                model.StartDateMessage="Start date is required";
                model.Error = true;
            }
            else
            {
                try
                {
                    var dateTime = DateTime.Parse(semester.StartDate);
                }
                catch
                {
                    model.StartDateMessage="Invalid start date";
                    model.Error = true;
                }
            }
            if (string.IsNullOrEmpty(semester.EndDate) || string.IsNullOrWhiteSpace(semester.EndDate))
            {
                model.EndDateMessage="End date is required";
                model.Error = true;
            }
            else
            {
                try
                {
                    var dateTime = DateTime.Parse(semester.EndDate);
                }
                catch
                {
                    model.EndDateMessage="Invalid end date";
                    model.Error = true;
                }
            }

            return model;
        }
    }
}

