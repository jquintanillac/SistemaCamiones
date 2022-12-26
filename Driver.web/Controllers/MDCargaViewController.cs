using Driver.web.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Controllers
{
    public class MDCargaViewController : Controller
    {
        private readonly Datacontext _ctx;
        // GET: MDCargaViewController

        public MDCargaViewController(Datacontext ctx)
        {
            _ctx = ctx;
        }

        public ActionResult Index()
        {
           return View();
        }

        // GET: MDCargaViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDCargaViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDCargaViewController/Create
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

        // GET: MDCargaViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDCargaViewController/Edit/5
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

        // GET: MDCargaViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDCargaViewController/Delete/5
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
