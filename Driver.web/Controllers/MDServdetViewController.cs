using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDServdetViewController : Controller
    {
        private readonly Datacontext _context;

        public MDServdetViewController(Datacontext context)
        {
            _context = context;
        }
        // GET: MDServdetViewController
        public ActionResult Index(int id)
        {
            var viajcab = _context.Servicio_Cabecera.Where(x => x.id_servcab == id).FirstOrDefault();
            ViewData["Nroviaje"] = viajcab.servcab_nro;
            ViewData["id_servcab"] = id;
            ViewBag.chofer = (from chof in _context.Chofer
                              select new
                              {
                                  id_chofer = chof.id_chofer,
                                  chofer_nomcompleto = chof.chofer_nombre + " " + chof.chofer_apellido
                              }).ToList();
            ViewBag.placa = _context.Vehiculos.ToList();
            ViewBag.transp = _context.Transportista.ToList();
            return View();
        }

        // GET: MDServdetViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDServdetViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDServdetViewController/Create
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

        // GET: MDServdetViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDServdetViewController/Edit/5
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

        // GET: MDServdetViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDServdetViewController/Delete/5
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
