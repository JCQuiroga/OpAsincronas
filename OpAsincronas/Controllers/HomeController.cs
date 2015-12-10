using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace OpAsincronas.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> AccionesConcatenadas()
        {
            var tarea1 = await TareaPesada.DiezSegundos();
            var tarea2 = await TareaPesada.CincoSegundos();
            return Content("Retardo total de 15 Segundos");
        }

        public async Task<ActionResult> AccionesSimultaneas()
        {
            var tarea1 = TareaPesada.DiezSegundos();
            var tarea2 = TareaPesada.CincoSegundos();
            await Task.WhenAll(tarea1, tarea2); 
            return Content("Retardo total de 10 Segundos");
        }
    }
}