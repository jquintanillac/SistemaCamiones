using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Driver.web.Data;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDProceso_VehiculoViewController : Controller
    {
        private readonly Datacontext _context;

        public MDProceso_VehiculoViewController(Datacontext context)
        {
            _context = context;
        }

        // GET: MDProceso_VehiculoViewController

        public ActionResult Index()
        {
            ViewBag.vehiculo = _context.Vehiculos.ToList();
            ViewBag.proces = _context.Procesos.ToList();
            return View();
        }

        // GET: MDProceso_VehiculoViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDProceso_VehiculoViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDProceso_VehiculoViewController/Create
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

        // GET: MDProceso_VehiculoViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDProceso_VehiculoViewController/Edit/5
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

        // GET: MDProceso_VehiculoViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDProceso_VehiculoViewController/Delete/5
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
