using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDGeneralesViewController : Controller
    {
        // GET: MDGeneralesViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDGeneralesViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDGeneralesViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDGeneralesViewController/Create
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

        // GET: MDGeneralesViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDGeneralesViewController/Edit/5
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

        // GET: MDGeneralesViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDGeneralesViewController/Delete/5
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
