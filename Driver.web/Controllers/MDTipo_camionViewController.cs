using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDTipo_camionViewController : Controller
    {
        // GET: MDTipo_camionViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDTipo_camionViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDTipo_camionViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDTipo_camionViewController/Create
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

        // GET: MDTipo_camionViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDTipo_camionViewController/Edit/5
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

        // GET: MDTipo_camionViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDTipo_camionViewController/Delete/5
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
