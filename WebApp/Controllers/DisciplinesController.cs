using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebApp.Models.ViewModels;
using WebApp.Services.Disciplines;
using WebApp.Validation.Disciplines;

namespace WebApp.Controllers
{
    public class DisciplinesController : Controller
    {
        private readonly DisciplinesService disciplinesService;

        private readonly DisciplinesValidation validatior;

        public DisciplinesController(DisciplinesService discipliesService, DisciplinesValidation validatior)
        {
            this.disciplinesService = discipliesService;
            this.validatior = validatior;
        }
        // GET: 
        public async Task<ActionResult> Index()
        {
            var model = await this.disciplinesService.GetAllDisciplines();
            return View(model);
        }

        // GET: Discplines/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

       // POST: Discliplines/Create
       [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<JsonResult> Create(Discipline discipline)
        {
            var messages = this.validatior.ValidateDisciplines(discipline);
            ViewBag.Validation = string.Join("", messages);
            await this.disciplinesService.Create(discipline);
            var model = this.disciplinesService.GetLastAddedDiscipline();

            return Json(model);
        }

        // Put: Discplines/Edit/5
        [HttpPut]
        public JsonResult Edit(Discipline discipline)
        {
            var model = this.validatior.ValidateEditDiscipline(discipline);
            if (model.Error)
            {
                return Json(new { success = false, result = model});
            }
            else
            {
                this.disciplinesService.Edit(discipline);
                return Json(new { success = true, result = discipline });
            }
        }
    }
}