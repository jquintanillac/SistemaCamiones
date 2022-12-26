using Driver.web.Data.Entities;
using Driver.web.Models;
using System.Collections.Generic;
namespace Driver.web.IServices
{
    public interface IMDProceso_EstadoServices
    {
        List<VMProcesoEstado> GetAll();
        MDProceso_Estado GetbyId(int id_proest);
        void Save(MDProceso_Estado oProest);
        void Update(MDProceso_Estado oProest);
        string Delete(int id_proest);
    }
}
