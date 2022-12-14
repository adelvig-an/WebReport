using BussinesLayer;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Diagnostics;
using WebReport.Models;

namespace WebReport.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager _dataManager;

        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<User> users = _dataManager.User.GetAll().ToList();
            return View(users);
        }

        public IActionResult Delete(int id)
        {
            foreach(var user in _dataManager.User.GetAll())
                if (user.Id == id)
                {
                    _dataManager.User.Delete(user);
                }
            return RedirectToAction("Index");
        }

        //GET - CREATE
        [HttpGet]
        public IActionResult Create(int id)
        {
            if (id != 0)
            {
                var userSelected = _dataManager.User.GetById(id);
                return View(userSelected);
            }
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                _dataManager.User.SaveUpdate(user);
                return RedirectToAction("Index");
            }
            return View(user);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}