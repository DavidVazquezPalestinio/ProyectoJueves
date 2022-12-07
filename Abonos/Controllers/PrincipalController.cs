using Abonos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Abonos.Controllers
{
    public class PrincipalController : Controller
    {
        private readonly AbonoRepositorio AbonoRepositorio;
        public PrincipalController(AbonoRepositorio pAbonoRepositorio)
        {
            AbonoRepositorio = pAbonoRepositorio;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
