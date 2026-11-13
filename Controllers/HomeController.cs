using Microsoft.AspNetCore.Mvc;
using calculadora_dotnet_mvc.Models;

namespace calculadora_dotnet_mvc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new CalculadoraModel());
        }

        [HttpPost]
        public IActionResult Index(CalculadoraModel modelo)
        {
            Console.WriteLine("\n--- INICIO DE PETICIÓN (REQUEST) ---");
            Console.WriteLine("[CONTROLADOR] Petición POST recibida desde la Vista.");
            modelo.Calcular();
            Console.WriteLine($"[CONTROLADOR] Resultado obtenido del Modelo: {modelo.Resultado}");
            Console.WriteLine("[CONTROLADOR] Devolviendo Vista actualizada...\n");
            return View(modelo);
        }
    }
}
