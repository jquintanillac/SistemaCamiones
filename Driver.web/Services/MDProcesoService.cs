using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDProcesoService : IMDProcesoServices
    {
        private readonly Datacontext _context;
        public MDProcesoService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_proces)
        {
            var proceso = _context.Procesos.FirstOrDefault(x => x.id_proces == id_proces);
            if (proceso != null)
            {
                _context.Procesos.Remove(proceso);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDProceso> GetAll()
        {
            return _context.Procesos.ToList();
        }

        public MDProceso GetbyId(int id_proces)
        {
            return _context.Procesos.SingleOrDefault(x => x.id_proces == id_proces);
        }

        public void Save(MDProceso oDProceso)
        {
            _context.Procesos.Add(oDProceso);
            _context.SaveChanges();
        }

        public void Update(MDProceso oDProceso)
        {
            _context.Procesos.Update(oDProceso);
            _context.SaveChanges();
        }
    }
}
