using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDEstadoViewController : Controller
    {
        // GET: MDEstadoViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDEstadoViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDEstadoViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDEstadoViewController/Create
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

        // GET: MDEstadoViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDEstadoViewController/Edit/5
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

        // GET: MDEstadoViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDEstadoViewController/Delete/5
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
