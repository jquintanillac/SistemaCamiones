using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDMantpredViewController : Controller
    {
        // GET: MDMantpredViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDMantpredViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDMantpredViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDMantpredViewController/Create
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

        // GET: MDMantpredViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDMantpredViewController/Edit/5
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

        // GET: MDMantpredViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDMantpredViewController/Delete/5
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
