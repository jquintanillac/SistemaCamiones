using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDGrifoService : IMDGrifoServices
    {
        private readonly Datacontext _context;

        public MDGrifoService(Datacontext context)
        {
            _context = context;
        }
        public string Delete(int id_grifo)
        {
            var grifo = _context.Grifos.FirstOrDefault(x => x.id_grifo == id_grifo);
            if (grifo != null)
            {
                _context.Grifos.Remove(grifo);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDGrifo> GetAll()
        {
            return _context.Grifos.ToList();
        }

        public MDGrifo GetbyId(int id_grifo)
        {
            return _context.Grifos.SingleOrDefault(x => x.id_grifo == id_grifo);
        }

        public void Save(MDGrifo oDGrifo)
        {
            _context.Grifos.Add(oDGrifo);
            _context.SaveChanges();
        }

        public void Update(MDGrifo oDGrifo)
        {
            _context.Grifos.Update(oDGrifo);
            _context.SaveChanges();
        }
    }
}
