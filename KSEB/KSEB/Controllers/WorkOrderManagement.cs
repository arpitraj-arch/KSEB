using Microsoft.AspNetCore.Mvc;

namespace KSEB.Controllers
{
    public class WorkOrderManagement : Controller
    {
        
        public IActionResult WorkOrderTracking()
        {
            return View();
        }
    }
}