using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDTipo_servicioService : IMDTipo_servicioServices
    {
        private readonly Datacontext _context;
        public MDTipo_servicioService(Datacontext context)
        {
            _context = context;
        }
        public string Delete(int id_tipserv)
        {
            var Tiposerv = _context.Tipo_Servicios.FirstOrDefault(x => x.id_tipserv == id_tipserv);
            if (Tiposerv != null)
            {
                _context.Tipo_Servicios.Remove(Tiposerv);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public MDTipo_servicio GetbyId(int id_tipserv)
        {
            return _context.Tipo_Servicios.SingleOrDefault(x => x.id_tipserv == id_tipserv);
        }

        public List<MDTipo_servicio> GetAll()
        {
            return _context.Tipo_Servicios.ToList();
        }

        public void Save(MDTipo_servicio oTiposerv)
        {
            _context.Tipo_Servicios.Add(oTiposerv);
            _context.SaveChanges();
        }

        public void Update(MDTipo_servicio oTiposerv)
        {
            _context.Tipo_Servicios.Update(oTiposerv);
            _context.SaveChanges();
        }
    }
}
