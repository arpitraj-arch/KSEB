using Microsoft.AspNetCore.Mvc;

namespace KSEB.Controllers
{
    public class SystemAdministrator : Controller
    {
        public IActionResult OrganisationSites()
        {
            return View();
        }

        public IActionResult People()
        {
            return View();
        }

        public IActionResult SecurityGroups()
        {
            return View();
        }

        public IActionResult WorkflowDesigner()
        {
            return View();
        }

        public IActionResult Escalations()
        {
            return View();
        }

        public IActionResult CommunicationTemplates()
        {
            //ViewData["ActiveMenu"] = "SystemAdministration";
            return View();

        }
    }
}
