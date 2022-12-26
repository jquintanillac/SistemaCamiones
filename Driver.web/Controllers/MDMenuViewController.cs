using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDMenuViewController : Controller
    {
        // GET: MDMenuViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDMenuViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDMenuViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDMenuViewController/Create
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

        // GET: MDMenuViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDMenuViewController/Edit/5
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

        // GET: MDMenuViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDMenuViewController/Delete/5
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
