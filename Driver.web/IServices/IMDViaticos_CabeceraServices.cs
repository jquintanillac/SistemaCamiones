using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDViaticos_CabeceraServices
    {
        List<MDViaticos_Cabecera> GetAll();
        MDViaticos_Cabecera GetbyId(int id_viatcab);

        void Save(MDViaticos_Cabecera oMDViaticos_Cabecera);
        void Update(MDViaticos_Cabecera oMDViaticos_Cabecera);
        string Delete(int id_viatcab);
    }
}
