using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using System.Collections.Generic;
using System.Linq;


namespace Driver.web.Services
{
    public class MDServicio_DetalleService : IMDServicio_DetalleServices
    {
        private readonly Datacontext _context;
        public MDServicio_DetalleService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_servdet)
        {
            var servdet = _context.Servicio_Detalle.FirstOrDefault(x => x.id_servdet == id_servdet);
            if (servdet != null)
            {
                _context.Servicio_Detalle.Remove(servdet);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDServicio_Detalle> GetAll()
        {
            return _context.Servicio_Detalle.ToList();
        }

        public List<VMDServicio_Detalle> GetbyId(int id_servcab)
        {
            var vmservi = (from servidet in _context.Servicio_Detalle
                           join chof in _context.Chofer on servidet.id_chofer equals chof.id_chofer
                           join plac in _context.Vehiculos on servidet.id_vehi equals plac.id_vehi
                           join tran in _context.Transportista on servidet.id_transp equals tran.id_transp
                           where servidet.id_servcab == id_servcab
                           select new VMDServicio_Detalle
                           {
                               id_servdet = servidet.id_servdet,
                               id_servcab = servidet.id_servcab,
                               id_transp  = servidet.id_transp,
                               transp_desc = tran.transp_desc,
                               id_chofer = servidet.id_chofer,
                               chof_nomcomp = chof.chofer_nombre + " " + chof.chofer_apellido,
                               id_vehi  = servidet.id_vehi,
                               vehi_placa = plac.vehi_placa,
                               servdet_cantdet = servidet.servdet_cantdet,
                               servdet_preunit = servidet.servdet_preunit
                           }).ToList();
            return vmservi;           
        }

        public void Save(MDServicio_Detalle oMDServicio_Detalle)
        {
            _context.Servicio_Detalle.Add(oMDServicio_Detalle);
            _context.SaveChanges();
        }

        public void Update(MDServicio_Detalle oMDServicio_Detalle)
        {
            _context.Servicio_Detalle.Update(oMDServicio_Detalle);
            _context.SaveChanges();
        }
    }
}
