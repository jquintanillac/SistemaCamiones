using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDMarcaViewController : Controller
    {
        // GET: MDMarcaViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDMarcaViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDMarcaViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDMarcaViewController/Create
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

        // GET: MDMarcaViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDMarcaViewController/Edit/5
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

        // GET: MDMarcaViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDMarcaViewController/Delete/5
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
