using Driver.web.Data;
using Driver.web.Data.DataSql;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDProceso_VehiculoService : IMDProceso_VehiculoServices
    {
        private readonly Datacontext _context;
        private readonly SP_Operaciones _Operaciones;
        public MDProceso_VehiculoService(Datacontext context)
        {
            _context = context;
            _Operaciones = new SP_Operaciones();
        }

        public string Delete(int id_provehi)
        {
            try
            {
                _Operaciones.mEliminarprocvehidet(id_provehi);
                var provehi = _context.Proceso_Vehiculos.FirstOrDefault(x => x.id_provehi == id_provehi);
                if (provehi != null)
                {
                    _context.Proceso_Vehiculos.Remove(provehi);
                    _context.SaveChanges();

                }

                return "Deleted";
            }
            catch (Exception ex)
            {

                throw ex;
            }
         
        }

        public List<VMProceso_Vehiculo> GetAll()
        {
            var vmprovehi = (from provehi in _context.Proceso_Vehiculos
                            join pro in _context.Procesos on provehi.id_proces equals pro.id_proces
                            join vehi in _context.Vehiculos on provehi.id_vehi equals vehi.id_vehi
                            select new VMProceso_Vehiculo
                            {
                                id_provehi = provehi.id_provehi,
                                vehi_placa = vehi.vehi_placa,
                                proces_desc = pro.proces_desc,
                                provehi_totalh = provehi.provehi_totalh,
                                provehi_obs = provehi.provehi_obs
                                
                            }).ToList();
            return vmprovehi;
        }

        public MDProceso_Vehiculo GetbyId(int id_provehi)
        {
            return _context.Proceso_Vehiculos.SingleOrDefault(x => x.id_provehi == id_provehi);
        }

        public void Save(MDProceso_Vehiculo oProvehi)
        {            
            _context.Proceso_Vehiculos.Add(oProvehi);
            _context.SaveChanges();

            _Operaciones.mGenerarprocvehidet(oProvehi.id_provehi);

        }

        public void Update(MDProceso_Vehiculo oProvehi)
        {
            _context.Proceso_Vehiculos.Update(oProvehi);
            _context.SaveChanges();
        }
    }
}
