using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Controllers
{
    public class MDRolperViewController : Controller
    {
        private readonly Datacontext _ctx;

        public MDRolperViewController(Datacontext ctx)
        {
            _ctx = ctx;
        }

        // GET: MDRolperViewController
        public ActionResult Index(int Idrol)
        {
            var id_rol = 0;
            if(Idrol == 0)
            {
                id_rol = 1;
            }
            else
            {
                id_rol = Idrol;
            }
            ViewData["Idrol2"] = id_rol;
            ViewBag.rol = _ctx.Rol.ToList();

            ViewBag.admin = (from rolper in _ctx.Rol_Permisos
                       join rol in _ctx.Rol on rolper.Idrol equals rol.Idrol
                       join menu in _ctx.Menus on rolper.id_menu equals menu.id_menu
                       join subm in _ctx.Submenus on rolper.id_submenu equals subm.id_submenu
                       where rol.Idrol == id_rol && rolper.id_menu == 1
                       select new VMRolperm
                       {
                           id_rolperm = rolper.id_rolperm,
                           rol_desc = rol.rol_desc,
                           menu_desc = menu.menu_desc,
                           submenu_desc = subm.submenu_desc,
                           rolperm_act = rolper.rolperm_act
                       }).ToList();

            ViewBag.plani = (from rolper in _ctx.Rol_Permisos
                       join rol in _ctx.Rol on rolper.Idrol equals rol.Idrol
                       join menu in _ctx.Menus on rolper.id_menu equals menu.id_menu
                       join subm in _ctx.Submenus on rolper.id_submenu equals subm.id_submenu
                       where rol.Idrol == id_rol && rolper.id_menu == 2
                       select new VMRolperm
                       {
                           id_rolperm = rolper.id_rolperm,
                           rol_desc = rol.rol_desc,
                           menu_desc = menu.menu_desc,
                           submenu_desc = subm.submenu_desc,
                           rolperm_act = rolper.rolperm_act
                       }).ToList();

            ViewBag.oper = (from rolper in _ctx.Rol_Permisos
                       join rol in _ctx.Rol on rolper.Idrol equals rol.Idrol
                       join menu in _ctx.Menus on rolper.id_menu equals menu.id_menu
                       join subm in _ctx.Submenus on rolper.id_submenu equals subm.id_submenu
                       where rol.Idrol == id_rol && rolper.id_menu == 3
                       select new VMRolperm
                       {
                           id_rolperm = rolper.id_rolperm,
                           rol_desc = rol.rol_desc,
                           menu_desc = menu.menu_desc,
                           submenu_desc = subm.submenu_desc,
                           rolperm_act = rolper.rolperm_act
                       }).ToList();

            ViewBag.logi = (from rolper in _ctx.Rol_Permisos
                       join rol in _ctx.Rol on rolper.Idrol equals rol.Idrol
                       join menu in _ctx.Menus on rolper.id_menu equals menu.id_menu
                       join subm in _ctx.Submenus on rolper.id_submenu equals subm.id_submenu
                       where rol.Idrol == id_rol && rolper.id_menu == 4
                       select new VMRolperm
                       {
                           id_rolperm = rolper.id_rolperm,
                           rol_desc = rol.rol_desc,
                           menu_desc = menu.menu_desc,
                           submenu_desc = subm.submenu_desc,
                           rolperm_act = rolper.rolperm_act
                       }).ToList();

            ViewBag.mante = (from rolper in _ctx.Rol_Permisos
                       join rol in _ctx.Rol on rolper.Idrol equals rol.Idrol
                       join menu in _ctx.Menus on rolper.id_menu equals menu.id_menu
                       join subm in _ctx.Submenus on rolper.id_submenu equals subm.id_submenu
                       where rol.Idrol == id_rol && rolper.id_menu == 5
                       select new VMRolperm
                       {
                           id_rolperm = rolper.id_rolperm,
                           rol_desc = rol.rol_desc,
                           menu_desc = menu.menu_desc,
                           submenu_desc = subm.submenu_desc,
                           rolperm_act = rolper.rolperm_act
                       }).ToList();

            ViewBag.tesor = (from rolper in _ctx.Rol_Permisos
                       join rol in _ctx.Rol on rolper.Idrol equals rol.Idrol
                       join menu in _ctx.Menus on rolper.id_menu equals menu.id_menu
                       join subm in _ctx.Submenus on rolper.id_submenu equals subm.id_submenu
                       where rol.Idrol == id_rol && rolper.id_menu == 6
                       select new VMRolperm
                       {
                           id_rolperm = rolper.id_rolperm,
                           rol_desc = rol.rol_desc,
                           menu_desc = menu.menu_desc,
                           submenu_desc = subm.submenu_desc,
                           rolperm_act = rolper.rolperm_act
                       }).ToList();

            ViewBag.repor = (from rolper in _ctx.Rol_Permisos
                             join rol in _ctx.Rol on rolper.Idrol equals rol.Idrol
                             join menu in _ctx.Menus on rolper.id_menu equals menu.id_menu
                             join subm in _ctx.Submenus on rolper.id_submenu equals subm.id_submenu
                             where rol.Idrol == id_rol && rolper.id_menu == 7
                             select new VMRolperm
                             {
                                 id_rolperm = rolper.id_rolperm,
                                 rol_desc = rol.rol_desc,
                                 menu_desc = menu.menu_desc,
                                 submenu_desc = subm.submenu_desc,
                                 rolperm_act = rolper.rolperm_act
                             }).ToList();            
            return View();
        }


        // GET: MDRolperViewController/Details/5
        public async Task<ActionResult> otorgar(IEnumerable<int> menus, int Idrol)
        {
            try
            {
                var desact = await _ctx.Rol_Permisos.Where(x => x.Idrol == Idrol).ToListAsync();
                foreach (var item in desact)
                {
                    var deschek = await _ctx.Rol_Permisos.Where(z => z.id_rolperm == item.id_rolperm).SingleOrDefaultAsync();
                    if (deschek != null)
                    {
                        deschek.rolperm_act = false;
                        _ctx.SaveChanges();
                    }
                }
                foreach (var item in menus)
                {
                    var update = await _ctx.Rol_Permisos.Where(x => x.id_rolperm == item).SingleOrDefaultAsync();
                    if (update != null)
                    {
                        update.rolperm_act = true;
                        _ctx.SaveChanges();
                    }                      
                }                          

            }
            catch (Exception ex)
            {
                throw ex;
            }
           
            return View();
        }

        // GET: MDRolperViewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MDRolperViewController/Create
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

        // GET: MDRolperViewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MDRolperViewController/Edit/5
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

        // GET: MDRolperViewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MDRolperViewController/Delete/5
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
