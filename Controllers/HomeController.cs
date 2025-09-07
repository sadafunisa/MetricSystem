using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var model = new TemperatureModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult Index(TemperatureModel model)
        {
            if (ModelState.IsValid)
            {
                model.ConvertToCelsius();
                ViewBag.ConvertedValue = model.CelsiusValue;
            }
            
            return View(model);
        }
    }
}