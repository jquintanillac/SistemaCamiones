using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDInventarioViewController : Controller
    {
        // GET: MDInventarioViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDInventarioViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDInventarioViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDInventarioViewController/Create
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

        // GET: MDInventarioViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDInventarioViewController/Edit/5
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

        // GET: MDInventarioViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDInventarioViewController/Delete/5
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
