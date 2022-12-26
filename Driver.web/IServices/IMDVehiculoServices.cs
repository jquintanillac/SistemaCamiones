using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDVehiculoServices
    {
        List<MDVehiculo> GetAll();
        MDVehiculo GetbyId(int id_vehi);
        void Save(MDVehiculo oDVehiculo);
        void Update(MDVehiculo oDVehiculo);
        string Delete(int id_vehi);
    }
}
