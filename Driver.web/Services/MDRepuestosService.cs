using Driver.web.Data;
using Driver.web.Data.DataSql;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDRepuestosService : IMDRepuestosServices
    {
        private readonly Datacontext _context;
        private readonly SP_Operaciones _Operaciones; 
        public MDRepuestosService(Datacontext context)
        {
            _context = context;
            _Operaciones = new SP_Operaciones();
        }

        public string Delete(int id_repuesto)
        {
            var repuesto = _context.Repuesto.FirstOrDefault(x => x.id_repuesto == id_repuesto);

            if (repuesto != null)
            {
                _context.Repuesto.Remove(repuesto);
                _context.SaveChanges();
                _Operaciones.mGenerarinventario(repuesto.id_product);
            }
            return "Deleted";
        }

        public List<VMDRepuestos> GetAll()
        {
            var vmrepuesto = (from repu in _context.Repuesto
                            join prod in _context.Productos on repu.id_product equals prod.id_product
                            select new VMDRepuestos
                            {
                                id_repuesto = repu.id_repuesto,
                                id_product = repu.id_product,
                                repus_iden = repu.repus_iden,
                                product_descr = prod.product_descr,
                                repus_cant = repu.repus_cant,
                                repus_preuni = repu.repus_preuni, 
                                repus_act = repu.repus_act,
                                repus_fecing = repu.repus_fecing
                            }).ToList();
            return vmrepuesto;
        }

        public MDRepuestos GetbyId(int id_repuesto)
        {
            return _context.Repuesto.SingleOrDefault(x => x.id_repuesto == id_repuesto);
        }

        public void Save(MDRepuestos oMDRepuestos)
        {
            _context.Repuesto.Add(oMDRepuestos);
            _context.SaveChanges();
            _Operaciones.mGenerarinventario(oMDRepuestos.id_product);


        }

        public void Update(MDRepuestos oMDRepuestos)
        {
            _context.Repuesto.Update(oMDRepuestos);
            _context.SaveChanges();
            _Operaciones.mGenerarinventario(oMDRepuestos.id_product);
        }
    }
}
