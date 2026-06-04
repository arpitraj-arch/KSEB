using Microsoft.AspNetCore.Mvc;

namespace KSEB.Controllers
{
    public class PlanningScheduling : Controller
    {
        public IActionResult JobsPlans()
        {
            return View();
        }
        public IActionResult SafetyPlans()
        {
            return View();
        }
        public IActionResult PreventiveMaintaince()
        {
            return View();
        }
        public IActionResult GraphicalScheduling()
        {
            return View();
        }
    }
}
