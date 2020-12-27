using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.ViewModels;
using WebApp.Services.Semesters;
using WebApp.Validation.Semesters;

namespace WebApp.Controllers
{
    public class SemestersController : Controller
    {
        private readonly SemestersService semestersService;

        private readonly SemestersValidation validatior;

        public SemestersController(SemestersService semestersService, SemestersValidation validatior)
        {
            this.semestersService = semestersService;
            this.validatior = validatior;
        }
        // GET: 
        public async Task<ActionResult> Index()
        {
            var model = await this.semestersService.GetAllSemesters();
            return View(model);
        }

        // GET: Discplines/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var model = await this.semestersService.GetSemesterDisciplines(id);
            return View(model);
        }

        // POST: Semesters/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<JsonResult> Create(Semester semester)
        {
            var messages = this.validatior.ValidateSemester(semester);
            ViewBag.Validation = string.Join("", messages);
            await this.semestersService.Create(semester);
            var model = this.semestersService.GetLastAddedSemester();

            return Json(model);
        }

        // Put: Semesters/Edit/5
        [HttpPut]
        public JsonResult Edit(Semester semester)
        {
            var model = this.validatior.ValidateEditSemester(semester);
            if (model.Error)
            {
                return Json(new { success = false, result = model });
            }
            else
            {
                this.semestersService.Edit(semester);
                return Json(new { success = true, result = semester });
            }
        }

        // Put: Semesters/AddDiscipline
        [HttpPut]
        public JsonResult AddDiscipline(AddSemesterDiscipline model)
        {
            this.semestersService.AddDiscipline(model);

            return Json(model);
        }

        [HttpPut]
        public JsonResult DeleteDiscipline(DeleteSemesterDiscipline model)
        {
            this.semestersService.DeleteDiscipline(model.DisId);

            return Json(model);
        }
    }
}