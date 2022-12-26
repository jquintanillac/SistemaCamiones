using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDProceso_VehiculoDetalleViewController : Controller
    {
        private readonly Datacontext _context;

        public MDProceso_VehiculoDetalleViewController(Datacontext context)
        {
            _context = context;
        }

        // GET: MDProceso_VehiculoDetalleViewController   
        public ActionResult Index(int id)
        {
            // ViewBag.provehi = _context.Proceso_VehiculoDetalles.Where(x => x.id_provehi == id).ToList();
            ViewData["id_provehi"] = id;
            return View();
        }

        // GET: MDProceso_VehiculoDetalleViewController/Details/5
        public ActionResult Redireccion()
        {
            return View();
        }

        // GET: MDProceso_VehiculoDetalleViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDProceso_VehiculoDetalleViewController/Create
              
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

        // GET: MDProceso_VehiculoDetalleViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDProceso_VehiculoDetalleViewController/Edit/5
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

        // GET: MDProceso_VehiculoDetalleViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDProceso_VehiculoDetalleViewController/Delete/5
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
