using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDTipo_licenciaService : IMDTipo_licenciaServices
    {
        private readonly Datacontext _context;

        public MDTipo_licenciaService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_tiplinc)
        {
            var tiplinc = _context.Tipo_Licencias.FirstOrDefault(x => x.id_tiplinc == id_tiplinc);
            if (tiplinc != null)
            {
                _context.Tipo_Licencias.Remove(tiplinc);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDTipo_licencia> GetAll()
        {
            return _context.Tipo_Licencias.ToList();
        }

        public MDTipo_licencia GetbyId(int id_tiplinc)
        {
            return _context.Tipo_Licencias.SingleOrDefault(x => x.id_tiplinc == id_tiplinc);
        }

        public void Save(MDTipo_licencia oMDTipolin)
        {
            _context.Tipo_Licencias.Add(oMDTipolin);
            _context.SaveChanges();
        }

        public void Update(MDTipo_licencia oMDTipolin)
        {
            _context.Tipo_Licencias.Update(oMDTipolin);
            _context.SaveChanges();
        }
    }
}
