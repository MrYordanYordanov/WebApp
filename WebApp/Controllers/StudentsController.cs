using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using WebApp.Models.ViewModels;
using WebApp.Services.Students;

namespace WebApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentsService studentService;

        public StudentsController(StudentsService studentService)
        {
            this.studentService = studentService;
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
        //[ValidateAntiForgeryToken]
        public async Task<JsonResult>  Create(Student student)
        {
            await this.studentService.Create(student);
            var model = this.studentService.GetLastAddedStudent();

            return Json(model);
        }
        
        // Put: Students/Edit/5
        [HttpPut]
        public JsonResult Edit(Student student)
        {
            this.studentService.Edit(student);

            return Json(student);
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