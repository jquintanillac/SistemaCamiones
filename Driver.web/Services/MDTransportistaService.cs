using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDTransportistaService : IMDTransportistaServices
    {
        private readonly Datacontext _context;
        public MDTransportistaService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_transp)
        {
            var trans = _context.Transportista.FirstOrDefault(x => x.id_transp == id_transp);
            if (trans != null)
            {
                _context.Transportista.Remove(trans);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDTransportista> GetAll()
        {
            return _context.Transportista.ToList();
        }

        public MDTransportista GetbyId(int id_transp)
        {
            return _context.Transportista.SingleOrDefault(x => x.id_transp == id_transp);
        }

        public void Save(MDTransportista oMDTransportista)
        {
            _context.Transportista.Add(oMDTransportista);
            _context.SaveChanges();
        }

        public void Update(MDTransportista oMDTransportista)
        {
            _context.Transportista.Update(oMDTransportista);
            _context.SaveChanges();
        }
    }
}
