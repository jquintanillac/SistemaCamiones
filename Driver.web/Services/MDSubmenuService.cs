using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDSubmenuService : IMDSubmenuServices
    {
        private readonly Datacontext _context;
        public MDSubmenuService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_submenu)
        {
            var submen = _context.Submenus.FirstOrDefault(x => x.id_submenu == id_submenu);
            if (submen != null)
            {
                _context.Submenus.Remove(submen);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<VMSubmenu> GetAll()
        {
            var vmsubmenu = (from sub in _context.Submenus
                             join men in _context.Menus on sub.id_menu equals men.id_menu                             
                             select new VMSubmenu
                             {
                                 id_submenu = sub.id_submenu,
                                 menu_desc = men.menu_desc,
                                 submenu_desc = sub.submenu_desc,
                                 submenu_iden = sub.submenu_iden
                             }).ToList();
            return vmsubmenu;
        }

        //public List<VMSubmenu> GetAll()
        //{
        //    return _context.Submenus.ToList();
        //}

        public MDSubmenu GetbyId(int id_submenu)
        {
            return _context.Submenus.SingleOrDefault(x => x.id_submenu == id_submenu);
        }

        public void Save(MDSubmenu oMDSubmenu)
        {
            _context.Submenus.Add(oMDSubmenu);
            _context.SaveChanges();
        }

        public void Update(MDSubmenu oMDSubmenu)
        {
            _context.Submenus.Update(oMDSubmenu);
            _context.SaveChanges();
        }
    }
}
