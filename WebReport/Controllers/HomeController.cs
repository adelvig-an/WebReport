using BussinesLayer;
using Microsoft.AspNetCore.Mvc;
using Model;
using System.Diagnostics;
using WebReport.Models;

namespace WebReport.Controllers
{
    public class HomeController : Controller
    {
        private DataManager _dataManager;

        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<User> users = _dataManager.User.GetAllUsers().ToList();
            return View(users);
        }


        [HttpGet]
        //[HttpGet("{id}")]
        //GET - CREATE
        public IActionResult Create(int id)
        {
            if (id != 0)
            {
                var userSelected = _dataManager.User.GetUserById(id);
                return View(userSelected);
                
            }
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            _dataManager.User.SaveUpdateUser(user);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}