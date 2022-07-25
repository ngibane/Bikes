using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Bikes.Models;

namespace Bikes.Controllers
{
    public class BikeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult GetBikes()
        {
            return View();
        }

        public JsonResult Bikes()
        {
            string filePant = "wwwroot/Data/bikes_response.json";
            using (StreamReader r = new StreamReader(filePant))
            {
                List<Bike> bikes = new List<Bike>();
                string json = r.ReadToEnd();
                bikes = JsonSerializer.Deserialize<List<Bike>>(json);
                return Json(bikes);
            }
        }
    }
}
