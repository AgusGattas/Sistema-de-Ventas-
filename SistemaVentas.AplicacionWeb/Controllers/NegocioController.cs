using Microsoft.AspNetCore.Mvc;

namespace SistemaVentas.AplicacionWeb.Controllers
{
    public class NegocioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
