using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDRoluserViewController : Controller
    {
        private readonly Datacontext _ctx;
        // GET: MDUsuarioViewController
        public MDRoluserViewController(Datacontext ctx)
        {
            _ctx = ctx;
        }
        // GET: MDRoluserViewController
        public ActionResult Index()
        {
            ViewBag.user = _ctx.Usuario.ToList();
            ViewBag.rol = _ctx.Rol.ToList();
            return View();
        }

        // GET: MDRoluserViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDRoluserViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDRoluserViewController/Create
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

        // GET: MDRoluserViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDRoluserViewController/Edit/5
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

        // GET: MDRoluserViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDRoluserViewController/Delete/5
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
