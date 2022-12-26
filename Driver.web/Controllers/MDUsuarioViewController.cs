using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDUsuarioViewController : Controller
    {       
        public ActionResult Index()
        {    
            return View();
        }

        // GET: MDUsuarioViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDUsuarioViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDUsuarioViewController/Create
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

        // GET: MDUsuarioViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDUsuarioViewController/Edit/5
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

        // GET: MDUsuarioViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDUsuarioViewController/Delete/5
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
