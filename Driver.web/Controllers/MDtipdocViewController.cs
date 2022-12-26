using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDtipdocViewController : Controller
    {
        // GET: MDtipdocViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDtipdocViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDtipdocViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDtipdocViewController/Create
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

        // GET: MDtipdocViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDtipdocViewController/Edit/5
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

        // GET: MDtipdocViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDtipdocViewController/Delete/5
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
