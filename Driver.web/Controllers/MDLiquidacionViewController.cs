using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Controllers
{
    public class MDLiquidacionViewController : Controller
    {
        private readonly Datacontext _context;
        public MDLiquidacionViewController(Datacontext context)
        {
            _context = context;
        }
        // GET: MDLiquidacionViewController
        public async Task<ActionResult> Index()
        {
            ViewBag.viatcab = await _context.Viaticos_Cabecera.ToListAsync();
            return View();
        }

        // GET: MDLiquidacionViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDLiquidacionViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDLiquidacionViewController/Create
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

        // GET: MDLiquidacionViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDLiquidacionViewController/Edit/5
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

        // GET: MDLiquidacionViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDLiquidacionViewController/Delete/5
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
