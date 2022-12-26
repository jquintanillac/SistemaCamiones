using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDViaticos_CabeceraService : IMDViaticos_CabeceraServices
    {
        private readonly Datacontext _context;
        public MDViaticos_CabeceraService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_viatcab)
        {
            var viatcab = _context.Viaticos_Cabecera.FirstOrDefault(x => x.id_viatcab == id_viatcab);
            if (viatcab != null)
            {
                _context.Viaticos_Cabecera.Remove(viatcab);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDViaticos_Cabecera> GetAll()
        {
            return _context.Viaticos_Cabecera.ToList();
        }

        public MDViaticos_Cabecera GetbyId(int id_viatcab)
        {
            return _context.Viaticos_Cabecera.SingleOrDefault(x => x.id_viatcab == id_viatcab);
        }

        public void Save(MDViaticos_Cabecera oMDViaticos_Cabecera)
        {
            _context.Viaticos_Cabecera.Add(oMDViaticos_Cabecera);
            _context.SaveChanges();
        }

        public void Update(MDViaticos_Cabecera oMDViaticos_Cabecera)
        {
            _context.Viaticos_Cabecera.Update(oMDViaticos_Cabecera);
            _context.SaveChanges();
        }
    }
}
