using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySqlConnector;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            var myConnectionString = "server=127.0.0.1;uid=root;" +
    "pwd=1234;database=school";
            var connection = new MySqlConnection(myConnectionString);
            await connection.OpenAsync();

            var command = new MySqlCommand("SELECT surname FROM students;", connection);
             var reader = await command.ExecuteReaderAsync();
            while (await reader.ReadAsync())
            {
                var value = reader.GetValue(0);
                // do something with 'value'
            }
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
