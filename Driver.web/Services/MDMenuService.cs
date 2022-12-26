using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDMenuService : IMDMenuServices
    {
        private readonly Datacontext _context;
        public MDMenuService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_menu)
        {
            var menu = _context.Menus.FirstOrDefault(x => x.id_menu == id_menu);
            if (menu != null)
            {
                _context.Menus.Remove(menu);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDMenu> GetAll()
        {
            return _context.Menus.ToList();
        }

        public MDMenu GetbyId(int id_menu)
        {
            return _context.Menus.SingleOrDefault(x => x.id_menu == id_menu);
        }

        public void Save(MDMenu oMDMenu)
        {
            _context.Menus.Add(oMDMenu);
            _context.SaveChanges();
        }

        public void Update(MDMenu oMDMenu)
        {
            _context.Menus.Update(oMDMenu);
            _context.SaveChanges();
        }
    }
}
