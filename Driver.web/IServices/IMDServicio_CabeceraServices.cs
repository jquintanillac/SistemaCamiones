using System.Collections.Generic;
using Driver.web.Data.Entities;
using Driver.web.Models;

namespace Driver.web.IServices
{
    public interface IMDServicio_CabeceraServices
    {
        List<VMDServicio_Cabecera> GetAll();
        MDServicio_Cabecera GetbyId(int id_servcab);

        void Save(VMDServicio_Cabecera oMDServicio_Cabecera);
        void Update(VMDServicio_Cabecera oMDServicio_Cabecera);
        string Delete(int id_servcab);
    }
}
