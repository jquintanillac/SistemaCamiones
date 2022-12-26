using System.Collections.Generic;
using Driver.web.Data.Entities;
using Driver.web.Models;

namespace Driver.web.IServices
{
    public interface IMDDocumento_CabeceraServices
    {
        List<VMDocumento_Cabecera> GetAll();
        List<VMDocumento_Cabecera> GetbyId(string id);

        void Save(VMDocumento_Cabecera oMDDoccab);
        void Update(VMDocumento_Cabecera oMDDoccab);
        string Delete(int id_doccab);
    }
}
