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

        public IActionResult Index()
        {
            List<User> usersList = _dataManager.User.GetAllUsers().ToList();
            return View(usersList);
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