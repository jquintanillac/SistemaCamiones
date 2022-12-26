using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDGrifoviewController : Controller
    {
        // GET: MDGrifoviewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDGrifoviewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDGrifoviewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDGrifoviewController/Create
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

        // GET: MDGrifoviewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDGrifoviewController/Edit/5
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

        // GET: MDGrifoviewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDGrifoviewController/Delete/5
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
