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
    public class MDDocumento_CabeceraService : IMDDocumento_CabeceraServices
    {
        private readonly Datacontext _context;
        private readonly SP_Operaciones _Operaciones;
        public MDDocumento_CabeceraService(Datacontext context)
        {
            _context = context;
            _Operaciones = new SP_Operaciones();
        }
        public string Delete(int id_doccab)
        {
            _Operaciones.mEliminardocudetalle(id_doccab);             
            var doccab = _context.Documento_Cabecera.FirstOrDefault(x => x.id_doccab == id_doccab);
            if (doccab != null)
            {
                _context.Documento_Cabecera.Remove(doccab);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<VMDocumento_Cabecera> GetAll()
        {
            DateTime fecha = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");
            //var doccab = _Operaciones.mListarDocumentoCabecera(fecha);
            return null;
        }

        public List<VMDocumento_Cabecera> GetbyId(string id)
        {
            DateTime fecha = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");
            var doccab = _Operaciones.mListarDocumentoCabecera(id, fecha);
            return doccab;
        }

        public void Save(VMDocumento_Cabecera oMDDoccab)
        {
            DateTime fecha = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");
            if (oMDDoccab.doccab_tipo == "C")
            {
                MDDocumento_Cabecera Doccab = new MDDocumento_Cabecera
                {
                    id_doccab = oMDDoccab.id_doccab,
                    id_chofer = oMDDoccab.id_chofer,
                    id_vehi   = oMDDoccab.id_vehi,
                    doccab_cod = oMDDoccab.doccab_cod,
                    doccab_tipo = oMDDoccab.doccab_tipo,
                    doccab_desc = oMDDoccab.doccab_desc,
                    doccab_fecreg = fecha
                };
                _context.Documento_Cabecera.Add(Doccab);
                _context.SaveChanges();
            }
            else
            {
                MDDocumento_Cabecera Doccab = new MDDocumento_Cabecera
                {
                    id_doccab = oMDDoccab.id_doccab,
                    id_chofer = oMDDoccab.id_chofer,
                    id_vehi = oMDDoccab.id_vehi,
                    doccab_cod = oMDDoccab.doccab_cod,
                    doccab_tipo = oMDDoccab.doccab_tipo,
                    doccab_desc = oMDDoccab.doccab_desc,
                    doccab_fecreg = fecha
                };
                _context.Documento_Cabecera.Add(Doccab);
                _context.SaveChanges();
            }
        }

        public void Update(VMDocumento_Cabecera oMDDoccab)
        {
            DateTime fecha = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");
            if (oMDDoccab.doccab_tipo == "C")
            {
                MDDocumento_Cabecera Doccab = new MDDocumento_Cabecera
                {
                    id_doccab = oMDDoccab.id_doccab,
                    id_chofer = oMDDoccab.id_chofer,
                    id_vehi = oMDDoccab.id_vehi,
                    doccab_cod = oMDDoccab.doccab_cod,
                    doccab_tipo = oMDDoccab.doccab_tipo,
                    doccab_desc = oMDDoccab.doccab_desc,
                    doccab_fecreg = fecha
                };
                _context.Documento_Cabecera.Update(Doccab);
                _context.SaveChanges();               

            }
            else
            {
                MDDocumento_Cabecera Doccab = new MDDocumento_Cabecera
                {
                    id_doccab = oMDDoccab.id_doccab,
                    id_chofer = oMDDoccab.id_chofer,
                    id_vehi = oMDDoccab.id_vehi,
                    doccab_cod = oMDDoccab.doccab_cod,
                    doccab_tipo = oMDDoccab.doccab_tipo,
                    doccab_desc = oMDDoccab.doccab_desc,
                    doccab_fecreg = fecha
                };
                _context.Documento_Cabecera.Update(Doccab);
                _context.SaveChanges();
            }

        }
    }
}
