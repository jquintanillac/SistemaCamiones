using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDModeloService : IMDModeloServices
    {
        private readonly Datacontext _context;

        public MDModeloService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_modelo)
        {
            var modelo = _context.Modelos.FirstOrDefault(x => x.id_modelo == id_modelo);
            if (modelo != null)
            {
                _context.Modelos.Remove(modelo);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDModelo> GetAll()
        {
            return _context.Modelos.ToList();
        }

        public MDModelo GetbyId(int id_modelo)
        {
            return _context.Modelos.SingleOrDefault(x => x.id_modelo == id_modelo);
        }

        public void Save(MDModelo oMDChofer)
        {
            _context.Modelos.Add(oMDChofer);
            _context.SaveChanges();
        }

        public void Update(MDModelo oMDChofer)
        {
            _context.Modelos.Update(oMDChofer);
            _context.SaveChanges();
        }
    }
}
