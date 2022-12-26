using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDTipo_SemiremolqueViewController : Controller
    {
        // GET: MDTipo_SemiremolqueViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDTipo_SemiremolqueViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDTipo_SemiremolqueViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDTipo_SemiremolqueViewController/Create
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

        // GET: MDTipo_SemiremolqueViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDTipo_SemiremolqueViewController/Edit/5
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

        // GET: MDTipo_SemiremolqueViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDTipo_SemiremolqueViewController/Delete/5
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
