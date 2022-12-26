using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDTipo_licenciaViewController : Controller
    {
        // GET: MDTipo_licenciaViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDTipo_licenciaViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDTipo_licenciaViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDTipo_licenciaViewController/Create
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

        // GET: MDTipo_licenciaViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDTipo_licenciaViewController/Edit/5
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

        // GET: MDTipo_licenciaViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDTipo_licenciaViewController/Delete/5
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
