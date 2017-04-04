using Birbiz.BusinessLogic.BusinessContracts;
using Microsoft.AspNetCore.Mvc;

namespace Birbiz.Presenter.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDatabaseService service;

        public HomeController(IDatabaseService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        // TODO: Remove after test
        public IActionResult CreateDatabase()
        {
            service.CreateIfNotExist();

            return Content("Success");
        }
    }
}