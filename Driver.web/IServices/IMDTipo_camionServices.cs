using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDTipo_camionServices
    {
        List<MDTipo_camion> GetAll();
        MDTipo_camion GetbyId(int id_Tipcam);
        void Save(MDTipo_camion oDTipo_Camion);
        void Update(MDTipo_camion oDTipo_Camion);
        string Delete(int id_Tipcam);
    }
}
