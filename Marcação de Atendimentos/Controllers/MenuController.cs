using Microsoft.AspNetCore.Mvc;

namespace Marcação_de_Atendimentos.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
