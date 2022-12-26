using System.Collections.Generic;
using Driver.web.Data.Entities;
using Driver.web.Models;

namespace Driver.web.IServices
{
    public interface IMDServicio_DetalleServices
    {
        List<MDServicio_Detalle> GetAll();
        List<VMDServicio_Detalle> GetbyId(int id_servcab);

        void Save(MDServicio_Detalle oMDServicio_Detalle);
        void Update(MDServicio_Detalle oMDServicio_Detalle);
        string Delete(int id_servdet);
    }
}
