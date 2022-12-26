using Driver.web.Data.Entities;
using Driver.web.Models;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDProceso_VehiculoServices
    {
        List<VMProceso_Vehiculo> GetAll();
        MDProceso_Vehiculo GetbyId(int id_provehi);
        void Save(MDProceso_Vehiculo oProvehi);
        void Update(MDProceso_Vehiculo oProvehi);
        string Delete(int id_provehi);
    }
}
