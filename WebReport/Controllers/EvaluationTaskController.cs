using BussinesLayer;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace WebReport.Controllers
{
    public class EvaluationTaskController : Controller
    {
        private readonly DataManager _dataManager;
        //Объект создан для теста
        public EvaluationTask _evaTask { get; set; }
        public EvaluationTaskController(DataManager dataManager)
        {
            _dataManager = dataManager;
            //Объект создан для теста
            _evaTask = new EvaluationTask()
            {
                Number = 1543,
                DateApplication = DateTime.Now,
                Target = TargetType.MarketValue
            };
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
            //Объект создан для теста
            return View(_evaTask);
        }
    }
}
