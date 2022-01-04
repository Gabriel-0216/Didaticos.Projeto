using Didaticos.Projeto.WebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Didaticos.Projeto.WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var bll = new BLL.Pessoa();
            bll.Add(new ViewModel.PessoaVM()
            {
                Sobrenome = "Souza",
                Nome = "Gabriel"
            });
            bll.Add(new ViewModel.PessoaVM()
            {
                Sobrenome = "Souza",
                Nome = "Gabriel 3"
            });
            bll.Add(new ViewModel.PessoaVM()
            {
                Sobrenome = "Souza",
                Nome = "Gabriel 2"
            });
            var list = bll.GetAll();
            return View(list);
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