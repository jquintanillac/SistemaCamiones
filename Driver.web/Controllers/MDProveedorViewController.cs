using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDProveedorViewController : Controller
    {
        private readonly Datacontext _ctx;
        // GET: MDCargaViewController

        public MDProveedorViewController(Datacontext ctx)
        {
            _ctx = ctx;
        }



        // GET: MDProveedorViewController
        public ActionResult Index()
        {
            ViewBag.tipdoc = _ctx.Tipo_Documento.Where(x => x.tipdoc_tipo == "R").ToList();
            return View();
        }

        // GET: MDProveedorViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDProveedorViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDProveedorViewController/Create
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

        // GET: MDProveedorViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDProveedorViewController/Edit/5
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

        // GET: MDProveedorViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDProveedorViewController/Delete/5
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
