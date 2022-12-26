using Driver.web.Data;
using Driver.web.Data.DataSql;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Driver.web.Services
{
    public class MDRepuestos_CamionService : IMDRepuestos_CamionServices
    {
        private readonly Datacontext _context;
        private readonly SP_Operaciones _Operaciones;
        public MDRepuestos_CamionService(Datacontext context)
        {
            _context = context;
            _Operaciones = new SP_Operaciones();
        }
        public string Delete(int id_repcam)
        {
            var repcam = _context.Repuesto_Camion.FirstOrDefault(x => x.id_repcam == id_repcam);
            if (repcam != null)
            {
                _context.Repuesto_Camion.Remove(repcam);
                _context.SaveChanges();
                _Operaciones.mGenerarinventario(repcam.id_product);

                var oEventos = _context.Eventos.Where(x => x.id_menu == id_repcam).SingleOrDefault();
                if (oEventos != null)
                {
                    _context.Eventos.Remove(oEventos);
                    _context.SaveChanges();
                }              

            }
            return "Deleted";
        }

        public List<VMDRepuestos_Camion> GetAll()
        {
            var vmrepcam = (from repcam in _context.Repuesto_Camion
                            join vehi in _context.Vehiculos  on repcam.id_vehi equals vehi.id_vehi
                            join prod in _context.Productos on repcam.id_product equals prod.id_product                            
                            select new VMDRepuestos_Camion
                            {
                                id_repcam = repcam.id_repcam,
                                id_product = repcam.id_product,
                                id_vehi = repcam.id_vehi,
                                vehi_placa = vehi.vehi_placa,
                                product_descr = prod.product_descr,
                                repcam_desc = repcam.repcam_desc,
                                repcam_cant = repcam.repcam_cant,
                                repcam_fecreg = repcam.repcam_fecreg,
                                repcam_fecsal = repcam.repcam_fecsal
                            }).ToList();
            return vmrepcam;
        }

        public MDRepuestos_Camion GetbyId(int id_repcam)
        {
            return _context.Repuesto_Camion.SingleOrDefault(x => x.id_repcam == id_repcam);
        }

        public void Save(MDRepuestos_Camion oMDRepuestoscamion)
        {
            //string Date1 = oMDRepuestoscamion.repcam_fecreg.ToString("dd-MM-yyyy");
            //string Date2 = oMDRepuestoscamion.repcam_fecsal.ToString("dd-MM-yyyy");
            //DateTime repcam_fecreg = DateTime.Parse(Date1);
            //DateTime repcam_desc = DateTime.Parse(Date2);
            //MDRepuestos_Camion mDRepuestos = new MDRepuestos_Camion
            //{
            //    id_product = oMDRepuestoscamion.id_product,
            //    id_vehi    = oMDRepuestoscamion.id_vehi,
            //    repcam_desc = oMDRepuestoscamion.repcam_desc,
            //    repcam_cant = oMDRepuestoscamion.repcam_cant,
            //    repcam_fecreg = oMDRepuestoscamion.repcam_fecreg,
            //    repcam_fecsal = oMDRepuestoscamion.repcam_fecsal
            //};
            _context.Repuesto_Camion.Add(oMDRepuestoscamion);
            _context.SaveChanges();
            _Operaciones.mGenerarinventario(oMDRepuestoscamion.id_product);

            var placa = _context.Vehiculos.Where(x => x.id_vehi == oMDRepuestoscamion.id_vehi).SingleOrDefault();
            MDEventos oEventos = new MDEventos
            {
                id_menu = oMDRepuestoscamion.id_repcam,
                title = placa.vehi_placa,
                StarDate = oMDRepuestoscamion.repcam_fecreg,
                EndDate = oMDRepuestoscamion.repcam_fecsal,
                Description = "Mantenimiento",
                Location = ""
            };
            _context.Eventos.Add(oEventos);
            _context.SaveChanges();
        }

        public void Update(MDRepuestos_Camion oMDRepuestoscamion)
        {
            _context.Repuesto_Camion.Update(oMDRepuestoscamion);
            _context.SaveChanges();
            _Operaciones.mGenerarinventario(oMDRepuestoscamion.id_product);
            var placa = _context.Vehiculos.Where(x => x.id_vehi == oMDRepuestoscamion.id_vehi).SingleOrDefault();
            MDEventos oEventos = new MDEventos
            {
                id_menu = oMDRepuestoscamion.id_repcam,
                title = placa.vehi_placa,
                StarDate = oMDRepuestoscamion.repcam_fecreg,
                EndDate = oMDRepuestoscamion.repcam_fecsal,
                Description = "Mantenimiento",
                Location = ""
            };
            _context.Eventos.Update(oEventos);
            _context.SaveChanges();
        }
    }
}
