using Microsoft.AspNetCore.Mvc;

namespace WebReport.Controllers
{
    public class ReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
