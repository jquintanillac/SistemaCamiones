using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Driver.web.Controllers
{
    public class MDCondicion_ContractualViewController : Controller
    {
        // GET: MDCondicion_ContractualViewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: MDCondicion_ContractualViewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MDCondicion_ContractualViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDCondicion_ContractualViewController/Create
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

        // GET: MDCondicion_ContractualViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDCondicion_ContractualViewController/Edit/5
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

        // GET: MDCondicion_ContractualViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDCondicion_ContractualViewController/Delete/5
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
