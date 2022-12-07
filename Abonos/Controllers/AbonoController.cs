
using Abonos.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace Abonos.Controllers
{
    public class AbonoController : Controller
    {
        private readonly PrincipalRepositorio PrincipalRepositorio;

        public AbonoController(PrincipalRepositorio pPrincipalRepositorio)
        {
            PrincipalRepositorio = pPrincipalRepositorio;
        }
        // GET: AbonoController
        public ActionResult Index()
        {
            return View();
        }
    }
}
