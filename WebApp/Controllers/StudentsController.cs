using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using WebApp.Models.ViewModels;
using WebApp.Services.Students;
using WebApp.Validation.Students;

namespace WebApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentsService studentService;

        private readonly StudentsValidation validatior;

        public StudentsController(StudentsService studentService, StudentsValidation validatior)
        {
            this.studentService = studentService;
            this.validatior = validatior;
        }
        // GET: Students
        public async Task<ActionResult> Index()
        {
            var model = await this.studentService.GetAllStudents();
            return View(model);
        }

        // GET: Students/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var model = await this.studentService.GetStudentSemesters(id);
            return View(model);
        }

        // POST: Students/Create
        [HttpPost]
        public async Task<JsonResult> Create(Student student)
        {
            var messages = this.validatior.ValidateStudent(student);
            ViewBag.Validation = string.Join("", messages);
            await this.studentService.Create(student);
            var model = this.studentService.GetLastAddedStudent();

            return Json(model);
        }

        // Put: Students/Edit/5
        [HttpPut]
        public JsonResult Edit(Student student)
        {
            var model = this.validatior.ValidateEditStudent(student);
            if (model.Error)
            {
                return Json(new { success = false, result = model });
            }
            else
            {
                this.studentService.Edit(student);
                return Json(new { success = true, result = student });
            }
        }

        // GET: Students/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }


        [HttpPut]
        public JsonResult AddSemester(AddStudentSemester model)
        {
            this.studentService.AddSemester(model);

            return Json(model);
        }
    }
}