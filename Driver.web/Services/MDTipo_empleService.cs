using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDTipo_empleService : IMDTipo_empleServices
    {
        private readonly Datacontext _context;

        public MDTipo_empleService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_tipempl)
        {
            var tipoemp = _context.Tipo_Emples.FirstOrDefault(x => x.id_tipempl == id_tipempl);
            if (tipoemp != null)
            {
                _context.Tipo_Emples.Remove(tipoemp);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDTipo_emple> GetAll()
        {
            return _context.Tipo_Emples.ToList();
        }

        public MDTipo_emple GetbyId(int id_tipempl)
        {
            return _context.Tipo_Emples.SingleOrDefault(x => x.id_tipempl == id_tipempl);
        }

        public void Save(MDTipo_emple oMDTipoemp)
        {
            _context.Tipo_Emples.Add(oMDTipoemp);
            _context.SaveChanges();
        }

        public void Update(MDTipo_emple oMDTipoemp)
        {
            _context.Tipo_Emples.Update(oMDTipoemp);
            _context.SaveChanges();
        }
    }
}
