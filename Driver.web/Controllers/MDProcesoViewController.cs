using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDProcesoViewController : Controller
    {
        // GET: MDProcesoViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDProcesoViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDProcesoViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDProcesoViewController/Create
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

        // GET: MDProcesoViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDProcesoViewController/Edit/5
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

        // GET: MDProcesoViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDProcesoViewController/Delete/5
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
