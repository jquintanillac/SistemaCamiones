using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;


namespace Driver.web.Services
{
    public class MDChoferService : IMDChoferServices
    {
        private readonly Datacontext _context;

        public MDChoferService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_chofer)
        {
            var chofer = _context.Chofer.FirstOrDefault(x => x.id_chofer == id_chofer);
            if (chofer != null)
            {
                _context.Chofer.Remove(chofer);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDChofer> GetAll()
        {
            return _context.Chofer.ToList();
        }

        public MDChofer GetbyId(int id_chofer)
        {
            return _context.Chofer.SingleOrDefault(x => x.id_chofer == id_chofer);
        }

        public void Save(MDChofer oMDChofer)
        {
            _context.Chofer.Add(oMDChofer);
            _context.SaveChanges();
        }

        public void Update(MDChofer oMDChofer)
        {
            _context.Chofer.Update(oMDChofer);
            _context.SaveChanges();
        }
    }
}
