using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDClienteViewController : Controller
    {
        private readonly Datacontext _ctx;
        // GET: MDCargaViewController

        public MDClienteViewController(Datacontext ctx)
        {
            _ctx = ctx;
        }


        // GET: MDClienteViewController
        public ActionResult Index()
        {
            ViewBag.tipdoc = _ctx.Tipo_Documento.Where(x => x.tipdoc_tipo == "R").ToList();
            return View();
        }

        // GET: MDClienteViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDClienteViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDClienteViewController/Create
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

        // GET: MDClienteViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDClienteViewController/Edit/5
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

        // GET: MDClienteViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDClienteViewController/Delete/5
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
