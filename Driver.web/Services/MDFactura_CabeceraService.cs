using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;


namespace Driver.web.Services
{
    public class MDFactura_CabeceraService : IMDFactura_cabeceraServices
    {
        private readonly Datacontext _context;

        public MDFactura_CabeceraService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_faccab)
        {
            var faccab = _context.Factura_Cabeceras.FirstOrDefault(x => x.id_faccab == id_faccab);
            if (faccab != null)
            {
                _context.Factura_Cabeceras.Remove(faccab);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDFactura_Cabecera> GetAll()
        {
            return _context.Factura_Cabeceras.ToList();
        }

        public MDFactura_Cabecera GetbyId(int id_faccab)
        {
            return _context.Factura_Cabeceras.SingleOrDefault(x => x.id_faccab == id_faccab);
        }

        public void Save(MDFactura_Cabecera omDFactura_Cabecera)
        {
            _context.Factura_Cabeceras.Add(omDFactura_Cabecera);
            _context.SaveChanges();
        }

        public void Update(MDFactura_Cabecera omDFactura_Cabecera)
        {
            _context.Factura_Cabeceras.Update(omDFactura_Cabecera);
            _context.SaveChanges();
        }
    }
}
