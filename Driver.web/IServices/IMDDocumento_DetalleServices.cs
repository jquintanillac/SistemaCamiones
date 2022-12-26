using System.Collections.Generic;
using Driver.web.Data.Entities;
using Driver.web.Models;

namespace Driver.web.IServices
{
    public interface IMDDocumento_DetalleServices
    {
        List<MDDocumento_Detalle> GetAll();
        List<VMDocumento_Detalle> GetbyId(int id_doccab);
        void Save(VMDocumento_Detalle oMDDocdet);
        void Update(VMDocumento_Detalle oMDDocdet);
        string Delete(int id_docdet);
    }
}
