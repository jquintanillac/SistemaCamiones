using Driver.web.Data.Entities;
using Driver.web.IServices;
using System.Collections.Generic;
using Driver.web.Data;
using System.Linq;
using Driver.web.Models;

namespace Driver.web.Services
{
    public class MDInventarioService : IMDInventarioServices
    {
        private readonly Datacontext _context;

        public MDInventarioService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_invet)
        {
            var invet = _context.Inventarios.FirstOrDefault(x => x.id_invet == id_invet);
            if (invet != null)
            {
                _context.Inventarios.Remove(invet);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<VMDInventario> GetAll()
        {
            var vminvet = (from invet in _context.Inventarios
                             join produ in _context.Productos on invet.id_product equals produ.id_product                      
                             select new VMDInventario
                             {
                                 id_invet = invet.id_invet,
                                 id_product = invet.id_product,
                                 product_descr = produ.product_descr,
                                 invet_cant = invet.invet_cant,
                                 invet_prepro = invet.invet_prepro,
                                 invet_pretotal = invet.invet_pretotal,
                                 invet_act = invet.invet_act

                             }).ToList();
            return vminvet;
        }

        public MDInventario GetbyId(int id_invet)
        {
            return _context.Inventarios.SingleOrDefault(x => x.id_invet == id_invet);
        }

        public void Save(MDInventario oInventario)
        {
            _context.Inventarios.Add(oInventario);
            _context.SaveChanges();
        }

        public void Update(MDInventario oInventario)
        {
            _context.Inventarios.Update(oInventario);
            _context.SaveChanges();
        }
    }
}
