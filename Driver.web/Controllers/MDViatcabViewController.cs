using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDViatcabViewController : Controller
    {
        private readonly Datacontext _context;
        public MDViatcabViewController(Datacontext context)
        {
            _context = context;
        }

        // GET: MDViatcabViewController
        public ActionResult Index()
        {
            ViewBag.viajes = _context.Servicio_Cabecera.ToList();
            return View();
        }

        // GET: MDViatcabViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDViatcabViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDViatcabViewController/Create
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

        // GET: MDViatcabViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDViatcabViewController/Edit/5
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

        // GET: MDViatcabViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDViatcabViewController/Delete/5
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
