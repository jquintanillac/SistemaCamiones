using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDTipo_semiremolqueService : IMDTipo_semiremolqueServices
    {
        private readonly Datacontext _context;

        public MDTipo_semiremolqueService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_Tipsemi)
        {
            var tipsemi = _context.Tipo_Semiremolques.FirstOrDefault(x => x.id_Tipsemi == id_Tipsemi);
            if (tipsemi != null)
            {
                _context.Tipo_Semiremolques.Remove(tipsemi);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDTipo_Semiremolque> GetAll()
        {
            return _context.Tipo_Semiremolques.ToList();
        }

        public MDTipo_Semiremolque GetbyId(int id_Tipsemi)
        {
            return _context.Tipo_Semiremolques.SingleOrDefault(x => x.id_Tipsemi == id_Tipsemi);
        }

        public void Save(MDTipo_Semiremolque oDTiposemi)
        {
            _context.Tipo_Semiremolques.Add(oDTiposemi);
            _context.SaveChanges();
        }

        public void Update(MDTipo_Semiremolque oDTiposemi)
        {
            _context.Tipo_Semiremolques.Update(oDTiposemi);
            _context.SaveChanges();
        }
    }
}
