using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDProceso_EstadoViewController : Controller
    {
        private readonly Datacontext _context;

        public MDProceso_EstadoViewController(Datacontext context)
        {
            _context = context;
        }

        // GET: MDProceso_EstadoViewController
        public ActionResult Index()
        {
            ViewBag.proces = _context.Procesos.ToList();
            ViewBag.estad = _context.Estado.ToList();
            return View();
        }

        // GET: MDProceso_EstadoViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDProceso_EstadoViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDProceso_EstadoViewController/Create
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

        // GET: MDProceso_EstadoViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDProceso_EstadoViewController/Edit/5
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

        // GET: MDProceso_EstadoViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDProceso_EstadoViewController/Delete/5
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
