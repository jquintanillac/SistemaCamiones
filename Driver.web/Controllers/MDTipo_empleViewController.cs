using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDTipo_empleViewController : Controller
    {
        // GET: MDTipo_empleViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDTipo_empleViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDTipo_empleViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDTipo_empleViewController/Create
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

        // GET: MDTipo_empleViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDTipo_empleViewController/Edit/5
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

        // GET: MDTipo_empleViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDTipo_empleViewController/Delete/5
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
