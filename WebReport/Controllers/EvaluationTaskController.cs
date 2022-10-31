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
                //SelecteCustomer(taskSelected.Customers);
                return View(taskSelected);
            }
            SelecteCustomer(CustomerType.PrivatePerson);
            return View();
        }

        public IActionResult GetPartialCustomer(CustomerType radioCustomer)
        {
            if (radioCustomer == CustomerType.PrivatePerson)
            {
                return PartialView("_PartialPrivatePerson");
            }
            return PartialView("_PartialOrganization");
        }

        [HttpPost]
        public IActionResult SelecteCustomer(CustomerType radioCustomer)
        {
            string authData = $"Customer: {radioCustomer}";
            return Content(authData);
        }
    }
}
