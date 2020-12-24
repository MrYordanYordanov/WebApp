using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models.ViewModels;
using WebApp.Services.Disciplines;

namespace WebApp.Controllers
{
    public class DisciplinesController : Controller
    {
        private readonly DisciplinesService disciplinesService;

        public DisciplinesController(DisciplinesService discipliesService)
        {
            this.disciplinesService = discipliesService;
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
            await this.disciplinesService.Create(discipline);
            var model = this.disciplinesService.GetLastAddedDiscipline();

            return Json(model);
        }

        // Put: Discplines/Edit/5
        [HttpPut]
        public JsonResult Edit(Discipline discipline)
        {
            this.disciplinesService.Edit(discipline);

            return Json(discipline);
        }
    }
}