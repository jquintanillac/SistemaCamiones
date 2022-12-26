using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDSubmenuViewController : Controller
    {
        private readonly Datacontext _ctx;
        // GET: MDUsuarioViewController
        public MDSubmenuViewController(Datacontext ctx)
        {
            _ctx = ctx;
        }

        // GET: MDSubmenuViewController
        public ActionResult Index()
        {
            ViewBag.menu = _ctx.Menus.ToList();
            return View();
        }

        // GET: MDSubmenuViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDSubmenuViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDSubmenuViewController/Create
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

        // GET: MDSubmenuViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDSubmenuViewController/Edit/5
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

        // GET: MDSubmenuViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDSubmenuViewController/Delete/5
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
