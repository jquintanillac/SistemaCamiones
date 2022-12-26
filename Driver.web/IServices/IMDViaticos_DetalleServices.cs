using System.Collections.Generic;
using Driver.web.Data.Entities;
using Driver.web.Models;

namespace Driver.web.IServices
{
    public interface IMDViaticos_DetalleServices
    {
        List<MDViaticos_Detalle> GetAll();
        List<VMViatico_Detalle> GetbyId(int id_viatdet);

        void Save(MDViaticos_Detalle oMDViaticos_Detalle);
        void Update(MDViaticos_Detalle oMDViaticos_Detalle);
        string Delete(int id_viatdet);
    }
}
