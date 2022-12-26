using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDGeneralesService : IMDGeneralesServices
    {
        private readonly Datacontext _context;

        public MDGeneralesService(Datacontext context)
        {
            _context = context;
        }
        public string Delete(int id_gene)
        {
            var gener = _context.Generales.FirstOrDefault(x => x.id_gene == id_gene);
            if (gener != null)
            {
                _context.Generales.Remove(gener);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDGenerales> GetAll()
        {
            return _context.Generales.ToList();
        }

        public MDGenerales GetbyId(int id_gene)
        {
            return _context.Generales.SingleOrDefault(x => x.id_gene == id_gene);
        }

        public void Save(MDGenerales oDGenerales)
        {
            _context.Generales.Add(oDGenerales);
            _context.SaveChanges();
        }

        public void Update(MDGenerales oDGenerales)
        {
            _context.Generales.Update(oDGenerales);
            _context.SaveChanges();
        }
    }
}
