using Microsoft.AspNetCore.Mvc;

namespace WebReport.Controllers
{
    public class EvaluationTaskController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EvaluationTaskPage()
        {
            return View();
        }
    }
}
