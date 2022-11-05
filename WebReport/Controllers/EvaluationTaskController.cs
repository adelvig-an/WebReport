using BussinesLayer;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebReport.Controllers
{
    public class EvaluationTaskController : Controller
    {
        private readonly DataManager _dataManager;

        public EvaluationTaskController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }


        [HttpGet]
        public IActionResult Index()
        {
            List<EvaluationTask> evaluationTasks = _dataManager.EvaluationTask.GetAll().ToList();
            return View(evaluationTasks);
        }

        public IActionResult EvaluationTaskPage(int id)
        {
            if (id != 0)
            {
                var taskSelected = _dataManager.EvaluationTask.GetById(id);
                return View(taskSelected);
            }
            return View();
        }

        [HttpGet]
        public PartialViewResult GetPartialCustomer(CustomerType radioCustomer)
        {
            if (radioCustomer == CustomerType.Organization)
            {
                return PartialView("_PartialOrganization");
            }
            return PartialView("_PartialPrivatePerson");
            
        }

        [HttpGet]
        public ActionResult _PartialPrivatePerson()
        {
            return PartialView("_PartialPrivatePerson");
        }

        [HttpGet]
        public ActionResult _PartialOrganization()
        {
            return PartialView("_PartialOrganization");
        }
    }
}
