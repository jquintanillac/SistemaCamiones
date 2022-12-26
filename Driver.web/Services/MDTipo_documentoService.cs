using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDTipo_documentoService : IMDTipo_documentoServices
    {
        private readonly Datacontext _context;
        public MDTipo_documentoService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_tipdoc)
        {
            var tipdoc = _context.Tipo_Documento.FirstOrDefault(x => x.id_tipdoc == id_tipdoc);
            if (tipdoc != null)
            {
                _context.Tipo_Documento.Remove(tipdoc);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDTipo_documento> GetAll()
        {
            return _context.Tipo_Documento.ToList();
        }

        public MDTipo_documento GetbyId(int id_tipdoc)
        {
            return _context.Tipo_Documento.SingleOrDefault(x => x.id_tipdoc == id_tipdoc);
        }

        public void Save(MDTipo_documento oMDTipo_documento)
        {
            _context.Tipo_Documento.Add(oMDTipo_documento);
            _context.SaveChanges();
        }

        public void Update(MDTipo_documento oMDTipo_documento)
        {
            _context.Tipo_Documento.Update(oMDTipo_documento);
            _context.SaveChanges();
        }
    }
}
