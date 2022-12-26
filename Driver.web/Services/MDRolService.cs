using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;


namespace Driver.web.Services
{
    public class MDRolService : IMDRolServices
    {
        private readonly Datacontext _context;
        public MDRolService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int Idrol)
        {
            var rol = _context.Rol.FirstOrDefault(x => x.Idrol == Idrol);
            if (rol != null)
            {
                _context.Rol.Remove(rol);
                _context.SaveChanges();
            }

            var Rolper = _context.Rol_Permisos.Where(x => x.Idrol == Idrol).ToList();
            foreach (var item in Rolper)
            {
                var rol_per = _context.Rol_Permisos.Where(y => y.id_rolperm == item.id_rolperm).SingleOrDefault();
                _context.Rol_Permisos.Remove(rol_per);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDRol> GetAll()
        {
            return _context.Rol.ToList();
        }

        public MDRol GetbyId(int Idrol)
        {
            return _context.Rol.SingleOrDefault(x => x.Idrol == Idrol);
        }

        public void Save(MDRol oMDRol)
        {
            _context.Rol.Add(oMDRol);
            _context.SaveChanges();

            var submenu = _context.Submenus.ToList();
            foreach (var item in submenu)
            {
                MDRol_Permisos rol_Permisos = new MDRol_Permisos
                {
                    Idrol = oMDRol.Idrol,
                    id_menu = item.id_menu,
                    id_submenu = item.id_submenu,
                    rolperm_act = false
                };                
                _context.Rol_Permisos.Add(rol_Permisos);
                _context.SaveChanges();
            }

        }

        public void Update(MDRol oMDRol)
        {
            _context.Rol.Update(oMDRol);
            _context.SaveChanges();
        }
    }
}
