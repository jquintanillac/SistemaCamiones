using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDServcabViewController : Controller
    {
        private readonly Datacontext _context;
        public MDServcabViewController(Datacontext context)
        {
            _context = context;
        }

        // GET: MDServcabViewController
        public ActionResult Index()
        {
            int nrosgte = 1;
            var sercab = _context.Servicio_Cabecera.OrderByDescending(x => x.id_servcab).FirstOrDefault();
            if(sercab == null)
            {
                nrosgte = 1;
            }
            else
            {
                nrosgte = sercab.id_servcab + 1;
            }
            
            string dcnro = nrosgte.ToString();
            int lg = dcnro.Length;

            switch (lg)
            {
                case 1:
                    dcnro = "NV" + "0000000" + dcnro;
                    break;
                case 2:
                    dcnro = "NV" + "000000" + dcnro;
                    break;
                case 3:
                    dcnro = "NV" + "00000" + dcnro;
                    break;
                case 4:
                    dcnro = "NV" + "0000" + dcnro;
                    break;
                case 5:
                    dcnro = "NV" + "000" + dcnro;
                    break;
                case 6:
                    dcnro = "NV" + "00" + dcnro;
                    break;
                case 7:
                    dcnro = "NV" + "0" + dcnro;
                    break;
                default:
                    dcnro = "NV" + dcnro;
                    break;
            }

            ViewData["Nroviaje"] = dcnro;

            ViewBag.cliente = _context.Cliente.ToList();
            ViewBag.carga   = _context.Carga.ToList();  
            ViewBag.origen  = _context.Ubigeo.ToList();
            ViewBag.destino = _context.Ubigeo.ToList();
            ViewBag.estado = _context.Tipo_Servicios.ToList();
            return View();
        }

        // GET: MDServcabViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDServcabViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDServcabViewController/Create
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

        // GET: MDServcabViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDServcabViewController/Edit/5
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

        // GET: MDServcabViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDServcabViewController/Delete/5
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
