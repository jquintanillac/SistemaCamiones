using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDLiquidacionService : IMDLiquidacionServices
    {
        private readonly Datacontext _context;

        public MDLiquidacionService(Datacontext context)
        {
            _context = context;
        }
        public string Delete(int id_liqui)
        {
            var liqui = _context.Liquidaciones.FirstOrDefault(x => x.id_liqui == id_liqui);
            if (liqui != null)
            {
                _context.Liquidaciones.Remove(liqui);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDLiquidacion> GetAll()
        {
            return _context.Liquidaciones.ToList();
            
        }

        public MDLiquidacion GetbyId(int id_liqui)
        {
            return _context.Liquidaciones.SingleOrDefault(x => x.id_liqui == id_liqui);
        }

        public void Save(MDLiquidacion oMDLiquidacion)
        {
            _context.Liquidaciones.Add(oMDLiquidacion);
            _context.SaveChanges();
        }

        public void Update(MDLiquidacion oMDLiquidacion)
        {
            _context.Liquidaciones.Update(oMDLiquidacion);
            _context.SaveChanges();
        }
    }
}
