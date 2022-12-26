using Driver.web.Data;
using Driver.web.Data.Entities;
using Driver.web.IServices;
using Driver.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Driver.web.Services
{
    public class MDServicio_CabeceraService : IMDServicio_CabeceraServices
    {
        private readonly Datacontext _context;
        public MDServicio_CabeceraService(Datacontext context)
        {
            _context = context;
        }

        public string Delete(int id_servcab)
        {
            var servcab = _context.Servicio_Cabecera.FirstOrDefault(x => x.id_servcab == id_servcab);
            if (servcab != null)
            {
                _context.Servicio_Cabecera.Remove(servcab);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<VMDServicio_Cabecera> GetAll()
        {
            var vmservi = (from servi in _context.Servicio_Cabecera
                             join clie in _context.Cliente on servi.id_cliente equals clie.id_cliente
                             join carg in _context.Carga on servi.id_carga equals carg.id_carga
                             join orig in _context.Ubigeo on servi.id_ubigeo_partida equals orig.id_ubigeo
                             join dest in _context.Ubigeo on servi.id_ubigeo_llegada equals dest.id_ubigeo
                             join esta in _context.Tipo_Servicios on servi.id_tipserv equals esta.id_tipserv
                           select new VMDServicio_Cabecera
                           {
                               id_servcab = servi.id_servcab,
                               id_cliente = (int)servi.id_cliente,
                               clie_razsocial = clie.clie_razsocial,
                               id_carga = (int)servi.id_carga,
                               carg_desc = carg.carg_desc,
                               id_ubigeo_partida = (int)servi.id_ubigeo_partida,
                               ubig_origen = orig.ubig_desc,
                               id_ubigeo_llegada = (int)servi.id_ubigeo_llegada,
                               ubig_llegada = dest.ubig_desc,
                               id_tipserv = (int)servi.id_tipserv,
                               tipserv_descr = esta.tipserv_descr,
                               servcab_guia = servi.servcab_guia,
                               servcab_nro = servi.servcab_nro,
                               servcab_desc = servi.servcab_desc,
                               servcab_fec = servi.servcab_fec,
                               servcab_canttotal = servi.servcab_canttotal,
                               servcab_montotal = servi.servcab_montotal,
                               servcab_km = servi.servcab_km,
                               servcab_obs = servi.servcab_obs
                           }).ToList();
            return vmservi;
        }

        public MDServicio_Cabecera GetbyId(int id_servcab)
        {
            return _context.Servicio_Cabecera.SingleOrDefault(x => x.id_servcab == id_servcab);
        }

        public void Save(VMDServicio_Cabecera oMDServicio_Cabecera)
        {
            DateTime fecha = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");

            MDServicio_Cabecera ServCab = new MDServicio_Cabecera
            {
                id_servcab = oMDServicio_Cabecera.id_servcab,
                id_cliente = oMDServicio_Cabecera.id_cliente,
                id_carga   = oMDServicio_Cabecera.id_carga,
                id_ubigeo_partida = oMDServicio_Cabecera.id_ubigeo_partida,
                id_ubigeo_llegada = oMDServicio_Cabecera.id_ubigeo_llegada,
                id_tipserv = oMDServicio_Cabecera.id_tipserv,
                servcab_nro  = oMDServicio_Cabecera.servcab_nro,
                servcab_guia = oMDServicio_Cabecera.servcab_guia,
                servcab_canttotal = oMDServicio_Cabecera.servcab_canttotal,
                servcab_desc = oMDServicio_Cabecera.servcab_desc,
                servcab_fec  = oMDServicio_Cabecera.servcab_fec,
                servcab_montotal = oMDServicio_Cabecera.servcab_montotal,
                servcab_km = oMDServicio_Cabecera.servcab_km,
                servcab_obs = oMDServicio_Cabecera.servcab_obs,
                servcab_fecreg = fecha
            };
            _context.Servicio_Cabecera.Add(ServCab);
            _context.SaveChanges();
        }

        public void Update(VMDServicio_Cabecera oMDServicio_Cabecera)
        {
            DateTime fecha = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");
            MDServicio_Cabecera ServCab = new MDServicio_Cabecera
            {                
                id_cliente = oMDServicio_Cabecera.id_cliente,
                id_carga = oMDServicio_Cabecera.id_carga,
                id_ubigeo_partida = oMDServicio_Cabecera.id_ubigeo_partida,
                id_ubigeo_llegada = oMDServicio_Cabecera.id_ubigeo_llegada,
                servcab_nro = oMDServicio_Cabecera.servcab_nro,
                servcab_canttotal = oMDServicio_Cabecera.servcab_canttotal,
                servcab_desc = oMDServicio_Cabecera.servcab_desc,
                servcab_fec = oMDServicio_Cabecera.servcab_fec,
                servcab_montotal = oMDServicio_Cabecera.servcab_montotal,
                servcab_km = oMDServicio_Cabecera.servcab_km,
                servcab_obs = oMDServicio_Cabecera.servcab_obs
            };
            _context.Servicio_Cabecera.Update(ServCab);
            _context.SaveChanges();
        }
    }
}
