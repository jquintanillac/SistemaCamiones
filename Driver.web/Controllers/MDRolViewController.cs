using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDRolViewController : Controller
    {
        // GET: MDRolViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDRolViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDRolViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDRolViewController/Create
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

        // GET: MDRolViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDRolViewController/Edit/5
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

        // GET: MDRolViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDRolViewController/Delete/5
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
