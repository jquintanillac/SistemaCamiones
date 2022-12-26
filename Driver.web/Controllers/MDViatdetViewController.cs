using Driver.web.Data;
using Driver.web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDViatdetViewController : Controller
    {
        private readonly Datacontext _context;
        public MDViatdetViewController(Datacontext context)
        {
            _context = context;
        }
        // GET: MDViatdetViewController
        public ActionResult Index(int id)
        {
            var id_viatcab = _context.Viaticos_Cabecera.Where(x => x.id_servcab == id).SingleOrDefault();
            ViewData["id_viatcab"] = id_viatcab.id_viatcab;
            ViewBag.chofer = (from viacab in _context.Servicio_Cabecera
                              join viadet in _context.Servicio_Detalle on viacab.id_servcab equals viadet.id_servcab
                              join chof in _context.Chofer on viadet.id_chofer equals chof.id_chofer
                              where viadet.id_servcab == id
                             select new VMChofer
                             {                                 
                                 id_chofer = chof.id_chofer,
                                 chofer_nomcompleto = chof.chofer_nombre + " " + chof.chofer_apellido 
                             }).ToList();
            return View();
        }

        // GET: MDViatdetViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDViatdetViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDViatdetViewController/Create
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

        // GET: MDViatdetViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDViatdetViewController/Edit/5
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

        // GET: MDViatdetViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDViatdetViewController/Delete/5
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
