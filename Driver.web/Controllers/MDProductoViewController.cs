using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDProductoViewController : Controller
    {
        // GET: MDProductoViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDProductoViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDProductoViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDProductoViewController/Create
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

        // GET: MDProductoViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDProductoViewController/Edit/5
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

        // GET: MDProductoViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDProductoViewController/Delete/5
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
