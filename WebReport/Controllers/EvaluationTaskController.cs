using BussinesLayer;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Drawing;

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

        [HttpPost]
        public IActionResult SelecteCustomer(CustomerType radioCustomer)
        {
            string authData = $"Customer: {radioCustomer}";
            return Content(authData);
        }
    }
}
