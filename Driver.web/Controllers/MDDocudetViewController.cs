using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDDocudetViewController : Controller
    {
        private readonly Datacontext _context;

        public MDDocudetViewController(Datacontext context)
        {
            _context = context;
        }
        // GET: MDDocudetViewController
        public ActionResult Index(int id)
        {    
            var docab = _context.Documento_Cabecera.Where(x => x.id_doccab == id).SingleOrDefault();
            if(docab.doccab_tipo == "C")
            {
                var chofer = _context.Chofer.Where(x => x.id_chofer == docab.id_chofer).SingleOrDefault();
                ViewData["nombre"] = chofer.chofer_nombre + " " + chofer.chofer_apellido;
                ViewData["id_doccab"] = docab.id_doccab;
                ViewBag.tipdoc = _context.Tipo_Documento.Where(x => x.tipdoc_tipo == "C");
            }
            else
            {
                var placa = _context.Vehiculos.Where(x => x.id_vehi == docab.id_vehi).SingleOrDefault();
                ViewData["nombre"] = placa.vehi_placa;
                ViewData["id_doccab"] = docab.id_doccab;
                ViewBag.tipdoc = _context.Tipo_Documento.Where(x => x.tipdoc_tipo == "P");
            }

            return View();
        }

        // GET: MDDocudetViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDDocudetViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDDocudetViewController/Create
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

        // GET: MDDocudetViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDDocudetViewController/Edit/5
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

        // GET: MDDocudetViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDDocudetViewController/Delete/5
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
