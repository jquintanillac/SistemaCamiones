using Driver.web.Data.Entities;
using Driver.web.Models;
using System.Collections.Generic;
namespace Driver.web.IServices
{
    public interface IMDProceso_VehiculoDetalle
    {
        List<VMProceso_VehiculoDetalle> GetAll();
        List<VMProceso_VehiculoDetalle> GetbyId(int id_provehi);
        void Save(MDProceso_VehiculoDetalle oProvehidet);
        void Update(MDProceso_VehiculoDetalle oProvehidet);
        string Delete(int id_provehidet);

    }
}
