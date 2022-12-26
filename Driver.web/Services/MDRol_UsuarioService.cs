using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using System.Collections.Generic;
using System.Linq;


namespace Driver.web.Services
{
    public class MDRol_UsuarioService : IMDRol_UsuarioServices
    {
        private readonly Datacontext _context;
        public MDRol_UsuarioService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int Idrol_usua)
        {
            var roluser = _context.Rol_Usuario.FirstOrDefault(x => x.Idrol_usua == Idrol_usua);
            if (roluser != null)
            {
                _context.Rol_Usuario.Remove(roluser);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public MDRol_Usuario GetbyId(int Idrol_usua)
        {
            return _context.Rol_Usuario.SingleOrDefault(x => x.Idrol_usua == Idrol_usua);
        }

        public void Save(MDRol_Usuario oMDRol_Usuario)
        {
            _context.Rol_Usuario.Add(oMDRol_Usuario);
            _context.SaveChanges();
        }

        public void Update(MDRol_Usuario oMDRol_Usuario)
        {
            _context.Rol_Usuario.Update(oMDRol_Usuario);
            _context.SaveChanges();
        }

        public List<VMRol_User> GetAll()
        {
            var vmroluser = (from roluser in _context.Rol_Usuario
                             join rol in _context.Rol on roluser.Idrol equals rol.Idrol
                             join user in _context.Usuario on roluser.IdUsuario equals user.IdUsuario
                             select new VMRol_User
                             {
                                 Idrol_usua = roluser.Idrol_usua,
                                 Idrol = rol.Idrol,
                                 IdUsuario = user.IdUsuario,
                                 Rol = rol.rol_desc,
                                 Usuario = user.Usua_user
                             }).ToList();
            return vmroluser;
        }
    }
}
