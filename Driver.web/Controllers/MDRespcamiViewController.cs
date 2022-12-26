using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Controllers
{
    public class MDRespcamiViewController : Controller
    {
        private readonly Datacontext _context;
        public MDRespcamiViewController(Datacontext context)
        {
            _context = context;
        }
        // GET: MDRespcamiViewController
        public ActionResult Index()
        {
            ViewBag.inventario = (from invent in _context.Inventarios
                                  join prod in _context.Productos on invent.id_product equals prod.id_product
                                  select new
                                  {
                                      id_product = invent.id_product ,
                                      product_descr = prod.product_descr
                                  }).ToList();
            ViewBag.vehiculo = _context.Vehiculos.ToList();
           // ViewBag.inventario = _context.Inventarios.ToList();
            return View();
        }

        // GET: MDRespcamiViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDRespcamiViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDRespcamiViewController/Create
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

        // GET: MDRespcamiViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDRespcamiViewController/Edit/5
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

        // GET: MDRespcamiViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDRespcamiViewController/Delete/5
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

        public async Task<IActionResult> Fulleventos()
        {
            var events = await _context.Eventos.ToListAsync();
            return View();
        }
    }
}
