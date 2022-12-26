using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDRepuestos_TercerosService : IMDRepuestos_TercerosServices
    {
        private readonly Datacontext _context;

        public MDRepuestos_TercerosService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_repter)
        {
            var repter = _context.Repuestos_Terceros.FirstOrDefault(x => x.id_repter == id_repter);
            if (repter != null)
            {
                _context.Repuestos_Terceros.Remove(repter);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<VMDRepuestos_Terceros> GetAll()
        {
            var vmrepter = (from repter in _context.Repuestos_Terceros
                            join vehi in _context.Vehiculos on repter.id_vehi equals vehi.id_vehi
                            join prod in _context.Productos on repter.id_product equals prod.id_product
                            select new VMDRepuestos_Terceros
                            {
                                id_repter = repter.id_repter,
                                id_product = repter.id_product,
                                id_vehi = repter.id_vehi,
                                vehi_placa = vehi.vehi_placa,
                                product_descr = prod.product_descr,
                                repter_desc = repter.repter_desc,
                                repter_cant = repter.repter_cant,
                                repter_costo = repter.repter_costo,
                                repter_fecreg = repter.repter_fecreg,
                                repter_fecsal = repter.repter_fecsal
                            }).ToList();
            return vmrepter;
        }

        public MDRepuestos_Terceros GetbyId(int id_repter)
        {
            return _context.Repuestos_Terceros.SingleOrDefault(x => x.id_repter == id_repter);
        }

        public void Save(MDRepuestos_Terceros oReputer)
        {
            _context.Repuestos_Terceros.Add(oReputer);
            _context.SaveChanges();
        }

        public void Update(MDRepuestos_Terceros oReputer)
        {
            _context.Repuestos_Terceros.Update(oReputer);
            _context.SaveChanges();
        }
    }
}
