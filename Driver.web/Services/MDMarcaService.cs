using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDMarcaService : IMDMarcaServices
    {
        private readonly Datacontext _context;

        public MDMarcaService(Datacontext context)
        {
            _context = context;
        }
        public string Delete(int id_marca)
        {
            var marca = _context.Marcas.FirstOrDefault(x => x.id_marca == id_marca);
            if (marca != null)
            {
                _context.Marcas.Remove(marca);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDMarca> GetAll()
        {
            return _context.Marcas.ToList();
        }

        public MDMarca GetbyId(int id_marca)
        {
            return _context.Marcas.SingleOrDefault(x => x.id_marca == id_marca);
        }

        public void Save(MDMarca oDMarca)
        {
            _context.Marcas.Add(oDMarca);
            _context.SaveChanges();
        }

        public void Update(MDMarca oDMarca)
        {
            _context.Marcas.Update(oDMarca);
            _context.SaveChanges();
        }
    }
}
