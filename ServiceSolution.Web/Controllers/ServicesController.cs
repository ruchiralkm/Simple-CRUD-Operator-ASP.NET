using Microsoft.AspNetCore.Mvc;
using ServiceSolution.Web.Models;

namespace ServiceSolution.Web.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            var service = new VehicleService
            {
                Id = 1,
                Title = "Test",
                Description = "Test",
                Cost = 69.9,
            };

            //ViewBag.Vehicle = service;
            ViewData["Service"] = service;

            return View();
        }

    }
}
