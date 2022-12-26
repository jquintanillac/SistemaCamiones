using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDProceso_VehiculoDetalleService : IMDProceso_VehiculoDetalle
    {
        private readonly Datacontext _context;
        public MDProceso_VehiculoDetalleService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_provehidet)
        {
            var provehidet = _context.Proceso_VehiculoDetalles.FirstOrDefault(x => x.id_provehidet == id_provehidet);
            if (provehidet != null)
            {
                _context.Proceso_VehiculoDetalles.Remove(provehidet);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<VMProceso_VehiculoDetalle> GetAll()
        {
            var vmdetvehi = (from detvehi in _context.Proceso_VehiculoDetalles
                            join proveh in _context.Proceso_Vehiculos on detvehi.id_provehi equals proveh.id_provehi
                            join proc in _context.Procesos on proveh.id_proces equals proc.id_proces
                            join est in _context.Estado on detvehi.id_estad equals est.id_estad                            
                            select new VMProceso_VehiculoDetalle
                            {
                                id_provehidet = detvehi.id_provehidet,
                                id_provehi = detvehi.id_provehi,
                                id_estad = detvehi.id_estad,
                                proces_desc = proc.proces_desc,
                                estad_desc = est.estad_desc,
                                provehidet_fecini = detvehi.provehidet_fecini,
                                provehidet_fecfin = detvehi.provehidet_fecfin
                            }).ToList();
            return vmdetvehi;
        }

        public List<VMProceso_VehiculoDetalle> GetbyId(int id_provehi)
        {
            var vmdetvehi = (from detvehi in _context.Proceso_VehiculoDetalles
                             join proveh in _context.Proceso_Vehiculos on detvehi.id_provehi equals proveh.id_provehi
                             join proc in _context.Procesos on proveh.id_proces equals proc.id_proces
                             join est in _context.Estado on detvehi.id_estad equals est.id_estad
                             where detvehi.id_provehi == id_provehi
                             select new VMProceso_VehiculoDetalle
                             {
                                 id_provehidet = detvehi.id_provehidet,
                                 id_provehi = detvehi.id_provehi,
                                 id_estad = detvehi.id_estad,
                                 proces_desc = proc.proces_desc,
                                 estad_desc = est.estad_desc,
                                 provehidet_fecini = detvehi.provehidet_fecini,
                                 provehidet_fecfin = detvehi.provehidet_fecfin
                             }).ToList();
            return vmdetvehi;
        }

        public void Save(MDProceso_VehiculoDetalle oProvehidet)
        {
            _context.Proceso_VehiculoDetalles.Add(oProvehidet);
            _context.SaveChanges();
        }

        public void Update(MDProceso_VehiculoDetalle oProvehidet)
        {
            _context.Proceso_VehiculoDetalles.Update(oProvehidet);
            _context.SaveChanges();
        }
    }
}
