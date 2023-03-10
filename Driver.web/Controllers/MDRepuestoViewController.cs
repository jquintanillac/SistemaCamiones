using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDRepuestoViewController : Controller
    {
        private readonly Datacontext _context;
        public MDRepuestoViewController(Datacontext context)
        {
            _context = context;
        }

        // GET: MDRepuestoViewController
        public ActionResult Index()
        {
            ViewBag.product = _context.Productos.ToList();
            return View();
        }

        // GET: MDRepuestoViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDRepuestoViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDRepuestoViewController/Create
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

        // GET: MDRepuestoViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDRepuestoViewController/Edit/5
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

        // GET: MDRepuestoViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDRepuestoViewController/Delete/5
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
