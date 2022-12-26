using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDEspecialidadViewController : Controller
    {
        // GET: MDEspecialidadViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDEspecialidadViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDEspecialidadViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDEspecialidadViewController/Create
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

        // GET: MDEspecialidadViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDEspecialidadViewController/Edit/5
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

        // GET: MDEspecialidadViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDEspecialidadViewController/Delete/5
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
