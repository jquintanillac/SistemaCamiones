using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;
using Driver.web.Helpers;
using Driver.Helpers;

namespace Driver.web.Services
{
    public class MDUsuarioService : IMDUsuarioServices
    {
        private readonly Datacontext _context;
        public MDUsuarioService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int IdUsuario)
        {
            var usuario = _context.Usuario.FirstOrDefault(x => x.IdUsuario == IdUsuario);
            if (usuario != null)
            {
                _context.Usuario.Remove(usuario);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDUsuario> GetAll()
        {
            return _context.Usuario.ToList();
        }

        public MDUsuario GetbyId(int IdUsuario)
        {
            return _context.Usuario.SingleOrDefault(x => x.IdUsuario == IdUsuario);
        }

        public void Save(MDUsuario oMDUsuario)
        {
            var hash = HashHelper.Hash(oMDUsuario.Usua_pass);
            MDUsuario dUsuario = new MDUsuario
            {
                Usua_user = oMDUsuario.Usua_user,
                Usua_nombres = oMDUsuario.Usua_nombres,
                Usua_apellidos = oMDUsuario.Usua_apellidos,
                Usua_email = oMDUsuario.Usua_email,
                Usua_pass = hash.Password,
                Usua_Hash = hash.Salt,
                Usua_act = true,
                Usua_imagen = oMDUsuario.Usua_imagen

            };
            _context.Usuario.Add(dUsuario);
            _context.SaveChanges();
        }

        public void Update(MDUsuario oMDUsuario)
        {
            _context.Usuario.Update(oMDUsuario);
            _context.SaveChanges();
        }
    }
}
