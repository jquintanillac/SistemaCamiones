using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDMantenimiento_PredictivoService : IMDMantenimiento_PredictivoServices
    {
        private readonly Datacontext _context;
        public MDMantenimiento_PredictivoService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_mantpred)
        {
            var mant = _context.Mantenimiento_Predictivo.FirstOrDefault(x => x.id_mantpred == id_mantpred);
            if (mant != null)
            {
                _context.Mantenimiento_Predictivo.Remove(mant);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDMantenimiento_Predictivo> GetAll()
        {
            return _context.Mantenimiento_Predictivo.ToList();
        }

        public MDMantenimiento_Predictivo GetbyId(int id_mantpred)
        {
            return _context.Mantenimiento_Predictivo.SingleOrDefault(x => x.id_mantpred == id_mantpred);
        }

        public void Save(MDMantenimiento_Predictivo oMDMantenimiento_Predictivo)
        {
            _context.Mantenimiento_Predictivo.Add(oMDMantenimiento_Predictivo);
            _context.SaveChanges();
        }

        public void Update(MDMantenimiento_Predictivo oMDMantenimiento_Predictivo)
        {
            _context.Mantenimiento_Predictivo.Update(oMDMantenimiento_Predictivo);
            _context.SaveChanges();
        }
    }
}
