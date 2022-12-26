using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDEstadosService : IMDEstadosServices
    {
        private readonly Datacontext _context;
        public MDEstadosService(Datacontext context)
        {
            _context = context;
        }
        public string Delete(int id_estad)
        {
            var est = _context.Estado.FirstOrDefault(x => x.id_estad == id_estad);
            if (est != null)
            {
                _context.Estado.Remove(est);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDEstados> GetAll()
        {
            return _context.Estado.ToList();
        }

        public MDEstados GetbyId(int id_estad)
        {
            return _context.Estado.SingleOrDefault(x => x.id_estad == id_estad);
        }

        public void Save(MDEstados oMDEstados)
        {
            _context.Estado.Add(oMDEstados);
            _context.SaveChanges();
        }

        public void Update(MDEstados oMDEstados)
        {
            _context.Estado.Update(oMDEstados);
            _context.SaveChanges();
        }
    }
}
