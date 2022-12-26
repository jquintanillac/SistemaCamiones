using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDProveedorService : IMDProveedorServices
    {
        private readonly Datacontext _context;
        public MDProveedorService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_proveedor)
        {
            var prove = _context.Proveedor.FirstOrDefault(x => x.id_proveedor == id_proveedor);
            if (prove != null)
            {
                _context.Proveedor.Remove(prove);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDProveedor> GetAll()
        {
            return _context.Proveedor.ToList();
        }

        public MDProveedor GetbyId(int id_proveedor)
        {
            return _context.Proveedor.SingleOrDefault(x => x.id_proveedor == id_proveedor);
        }

        public void Save(MDProveedor oMDProveedor)
        {
            _context.Proveedor.Add(oMDProveedor);
            _context.SaveChanges();
        }

        public void Update(MDProveedor oMDProveedor)
        {
            _context.Proveedor.Update(oMDProveedor);
            _context.SaveChanges();
        }
    }
}
