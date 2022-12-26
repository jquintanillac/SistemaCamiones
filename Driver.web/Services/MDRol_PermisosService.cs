using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using System.Collections.Generic;
using System.Linq;


namespace Driver.web.Services
{
    public class MDRol_PermisosService : IMDRol_PermisosServices
    {
        private readonly Datacontext _context;
        public MDRol_PermisosService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_rolperm)
        {
            var rolperm = _context.Rol_Permisos.FirstOrDefault(x => x.id_rolperm == id_rolperm);
            if (rolperm != null)
            {
                _context.Rol_Permisos.Remove(rolperm);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<VMRolperm> GetAll()
        {
            var vmrolper = (from rolper in _context.Rol_Permisos
                             join rol in _context.Rol on rolper.Idrol equals rol.Idrol
                             join menu in _context.Menus on rolper.id_menu equals menu.id_menu
                             join subm in _context.Submenus on rolper.id_submenu equals subm.id_submenu
                             select new VMRolperm
                             {
                                id_rolperm = rolper.id_rolperm,
                                rol_desc = rol.rol_desc,
                                menu_desc = menu.menu_desc,
                                submenu_desc = subm.submenu_desc,
                                rolperm_act = rolper.rolperm_act
                             }).ToList();
            return vmrolper;
        }  

        public MDRol_Permisos GetbyId(int id_rolperm)
        {
            return _context.Rol_Permisos.SingleOrDefault(x => x.id_rolperm == id_rolperm);
        }

        public void Save(MDRol_Permisos oMDRol_Permisos)
        {
            _context.Rol_Permisos.Add(oMDRol_Permisos);
            _context.SaveChanges();
        }

        public void Update(MDRol_Permisos oMDRol_Permisos)
        {
            _context.Rol_Permisos.Update(oMDRol_Permisos);
            _context.SaveChanges();
        }
    }
}
