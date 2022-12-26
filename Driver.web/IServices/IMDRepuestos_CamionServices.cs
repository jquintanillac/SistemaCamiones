using System.Collections.Generic;
using Driver.web.Data.Entities;
using Driver.web.Models;

namespace Driver.web.IServices
{
    public interface IMDRepuestos_CamionServices
    {
        List<VMDRepuestos_Camion> GetAll();
        MDRepuestos_Camion GetbyId(int id_repcam);

        void Save(MDRepuestos_Camion oMDRepuestoscamion);
        void Update(MDRepuestos_Camion oMDRepuestoscamion);
        string Delete(int id_repcam);
    }
}
