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
    public class MDDocumento_DetalleService : IMDDocumento_DetalleServices
    {
        private readonly Datacontext _context;
        private readonly SP_Operaciones _Operaciones;
        public MDDocumento_DetalleService(Datacontext context)
        {
            _context = context;
            _Operaciones = new SP_Operaciones();
        }

        public string Delete(int id_docdet)
        {
            var docdet = _context.Documento_Detalle.FirstOrDefault(x => x.id_docdet == id_docdet);
            if (docdet != null)
            {
                _context.Documento_Detalle.Remove(docdet);
                _context.SaveChanges();
            }
            return "Deleted";
        }

        public List<MDDocumento_Detalle> GetAll()
        {
            return _context.Documento_Detalle.ToList();
        }

        public List<VMDocumento_Detalle> GetbyId(int id_doccab)
        {
            DateTime fecha = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");
            var docdet = _Operaciones.mListarDocumentodetalle(id_doccab, fecha);
            return docdet;
        }

        public void Save(VMDocumento_Detalle oMDDocdet)
        {
            DateTime fecha = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");
            MDDocumento_Detalle oDocdet = new MDDocumento_Detalle
            {
                id_doccab = oMDDocdet.id_doccab,
                id_tipdoc = oMDDocdet.id_tipdoc,
                docdet_fecemi = oMDDocdet.docdet_fecemi,
                docdet_venci = oMDDocdet.docdet_venci,
                docdet_regis = fecha,
                docdet_entemi = oMDDocdet.docdet_entemi,
                docdet_obse = oMDDocdet.docdet_obse
            };
            _context.Documento_Detalle.Add(oDocdet);
            _context.SaveChanges();
        }

        public void Update(VMDocumento_Detalle oMDDocdet)
        {
            DateTime fecha = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.Now, "SA Pacific Standard Time");
            MDDocumento_Detalle oDocdet = new MDDocumento_Detalle
            {
                id_docdet = oMDDocdet.id_docdet,
                id_doccab = oMDDocdet.id_doccab,
                id_tipdoc = oMDDocdet.id_tipdoc,
                docdet_fecemi = oMDDocdet.docdet_fecemi,
                docdet_venci = oMDDocdet.docdet_venci,
                docdet_entemi = oMDDocdet.docdet_entemi,
                docdet_obse = oMDDocdet.docdet_obse
            };
            _context.Documento_Detalle.Update(oDocdet);
            _context.SaveChanges();
        }
    }
}
