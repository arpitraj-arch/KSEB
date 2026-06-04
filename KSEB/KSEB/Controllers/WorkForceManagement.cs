using Microsoft.AspNetCore.Mvc;

namespace KSEB.Controllers
{
    public class WorkForceManagement : Controller
    {
        public IActionResult Sunrisemeetingeregister()
        {
            return View();
        }
        public IActionResult crew()
        {
            return View();
        }
        public IActionResult LabourCrafts()
        {
            return View();
        }
        public IActionResult Shifts()
        {
            return View();
        }
    }
}
