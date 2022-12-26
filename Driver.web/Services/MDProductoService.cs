using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDProductoService : IMDProductoServices
    {
        private readonly Datacontext _context;

        public MDProductoService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_product)
        {
            var product = _context.Productos.FirstOrDefault(x => x.id_product == id_product);
            if (product != null)
            {
                _context.Productos.Remove(product);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDProducto> GetAll()
        {
            return _context.Productos.ToList();
        }

        public MDProducto GetbyId(int id_product)
        {
            return _context.Productos.SingleOrDefault(x => x.id_product == id_product);
        }

        public void Save(MDProducto oProdcut)
        {
            _context.Productos.Add(oProdcut);
            _context.SaveChanges();
        }

        public void Update(MDProducto oProdcut)
        {
            _context.Productos.Update(oProdcut);
            _context.SaveChanges();
        }
    }
}
