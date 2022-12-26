using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDCombustibleViewController : Controller
    {
        private readonly Datacontext _context;

        public MDCombustibleViewController(Datacontext context)
        {
            _context = context;
        }
        // GET: MDCombustibleViewController
        public ActionResult Index()
        {
            ViewBag.placa = _context.Vehiculos.ToList();
            ViewBag.grifo = _context.Grifos.ToList();
            return View();
        }

        // GET: MDCombustibleViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDCombustibleViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDCombustibleViewController/Create
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

        // GET: MDCombustibleViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDCombustibleViewController/Edit/5
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

        // GET: MDCombustibleViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDCombustibleViewController/Delete/5
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
