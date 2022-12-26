using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDVehiculoViewController : Controller
    {
        private readonly Datacontext _ctx;
        // GET: MDCargaViewController

        public MDVehiculoViewController(Datacontext ctx)
        {
            _ctx = ctx;
        }
        // GET: MDVehiculoViewController
        public ActionResult Index()
        {
            ViewBag.Tipcam = _ctx.Tipo_Camiones.ToList();
            ViewBag.Tipsemi = _ctx.Tipo_Semiremolques.ToList();
            ViewBag.cliente = _ctx.Cliente.ToList();
            ViewBag.modelo = _ctx.Modelos.ToList();
            ViewBag.marca = _ctx.Marcas.ToList();
            return View();
        }

        // GET: MDVehiculoViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDVehiculoViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDVehiculoViewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MDVehiculoViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDVehiculoViewController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MDVehiculoViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDVehiculoViewController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
