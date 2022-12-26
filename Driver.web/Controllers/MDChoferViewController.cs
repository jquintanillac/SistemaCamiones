using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDChoferViewController : Controller
    {
        private readonly Datacontext _ctx;
        // GET: MDCargaViewController

        public MDChoferViewController(Datacontext ctx)
        {
            _ctx = ctx;
        }
        // GET: MDChoferViewController
        public ActionResult Index()
        {
            ViewBag.tipempl    = _ctx.Tipo_Emples.ToList();
            ViewBag.cliente    = _ctx.Cliente.ToList();
            ViewBag.espec      = _ctx.Especialidades.ToList();
            ViewBag.concontrac = _ctx.Condicion_Contractuales.ToList(); 
            return View();
        }

        // GET: MDChoferViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDChoferViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDChoferViewController/Create
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

        // GET: MDChoferViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDChoferViewController/Edit/5
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

        // GET: MDChoferViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDChoferViewController/Delete/5
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
