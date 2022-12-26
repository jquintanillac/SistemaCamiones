using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Controllers
{
    public class MDFaccabViewController : Controller
    {
        private readonly Datacontext _context;

        public MDFaccabViewController(Datacontext context)
        {
            _context = context;
        }
        // GET: MDFaccabViewController
        public async Task<ActionResult> Index()
        {
            ViewBag.cliente = await _context.Cliente.ToListAsync();
            ViewBag.viaje = await _context.Servicio_Cabecera.ToListAsync();
            ViewBag.tipodoc = await _context.Tipo_Documento.Where(x => x.tipdoc_tipo == "F").ToListAsync();
            return View();
        }

        // GET: MDFaccabViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDFaccabViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDFaccabViewController/Create
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

        // GET: MDFaccabViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDFaccabViewController/Edit/5
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

        // GET: MDFaccabViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDFaccabViewController/Delete/5
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
