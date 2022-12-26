using Driver.web.Data;
using Driver.web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Driver.web.Controllers
{
    public class MDDocucabeViewController : Controller
    {
        private readonly Datacontext _context;

        public MDDocucabeViewController(Datacontext context)
        {
            _context = context;
        }
        // GET: MDDocucabeViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDDocucabeViewController
        public ActionResult Chofer()
        {            
            var Doccab = _context.Documento_Cabecera.OrderByDescending(x => x.id_doccab).FirstOrDefault();
            int nrosgte = Doccab.id_doccab + 1;
            string dcnro = nrosgte.ToString();
            int lg = dcnro.Length;

            switch (lg)
            {
                case 1:
                    dcnro = "DC" + "0000000" + dcnro;
                    break;
                case 2:
                    dcnro = "DC" + "000000" + dcnro;
                    break;
                case 3:
                    dcnro = "DC" + "00000" + dcnro;
                    break;
                case 4:
                    dcnro = "DC" + "0000" + dcnro;
                    break;
                case 5:
                    dcnro = "DC" + "000" + dcnro;
                    break;
                case 6:
                    dcnro = "DC" + "00" + dcnro;
                    break;
                case 7:
                    dcnro = "DC" + "0" + dcnro;
                    break;
                default:
                    dcnro = "DC" + dcnro;
                    break;
            }

            ViewData["Nrodoc"] = dcnro;
            ViewBag.chofer =(from chof in _context.Chofer
                             select new 
                            {
                            id_chofer = chof.id_chofer,
                            chofer_nomcompleto = chof.chofer_nombre + " " + chof.chofer_apellido
                            }).ToList();                                    
            return View();
        }

        // GET: MDDocucabeViewController
        public ActionResult Vehiculo()
        {
            var Doccab = _context.Documento_Cabecera.OrderByDescending(x => x.id_doccab).FirstOrDefault();
            int nrosgte = Doccab.id_doccab + 1;
            string dcnro = nrosgte.ToString();
            int lg = dcnro.Length;

            switch (lg)
            {
                case 1:
                    dcnro = "DC" + "0000000" + dcnro;
                    break;
                case 2:
                    dcnro = "DC" + "000000" + dcnro;
                    break;
                case 3:
                    dcnro = "DC" + "00000" + dcnro;
                    break;
                case 4:
                    dcnro = "DC" + "0000" + dcnro;
                    break;
                case 5:
                    dcnro = "DC" + "000" + dcnro;
                    break;
                case 6:
                    dcnro = "DC" + "00" + dcnro;
                    break;
                case 7:
                    dcnro = "DC" + "0" + dcnro;
                    break;
                default:
                    dcnro = "DC" + dcnro;
                    break;
            }

            ViewData["Nrodoc"] = dcnro;
            ViewBag.placa = _context.Vehiculos.ToList();
            return View();
        }


        // GET: MDDocucabeViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDDocucabeViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDDocucabeViewController/Create
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

        // GET: MDDocucabeViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDDocucabeViewController/Edit/5
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

        // GET: MDDocucabeViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDDocucabeViewController/Delete/5
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
