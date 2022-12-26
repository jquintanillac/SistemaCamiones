using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDcargaService : IMDcargaServices
    {
        private readonly Datacontext _context;

        public MDcargaService(Datacontext context)
        {
            _context = context;
        }
        public string Delete(int id_carga)
        {
            var carga = _context.Carga.FirstOrDefault(x => x.id_carga == id_carga);
            if (carga != null)
            {
                _context.Carga.Remove(carga);
                _context.SaveChanges();                 
            }
            return "Deleted";
        }

        public MDCarga GetbyId(int id_carga)
        {
            return _context.Carga.SingleOrDefault(x=>x.id_carga == id_carga);
        }

        public  List<MDCarga> GetMDCargas()
        {
            return _context.Carga.ToList();
        }

        public void Save(MDCarga oMDcarga)
        {
            _context.Carga.Add(oMDcarga);
            _context.SaveChanges();
        }

        public void Update(MDCarga oMDcarga)
        {
            _context.Carga.Update(oMDcarga);
            _context.SaveChanges();
        }
    }
}
