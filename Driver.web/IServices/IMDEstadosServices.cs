using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDEstadosServices
    {
        List<MDEstados> GetAll();
        MDEstados GetbyId(int id_estad);

        void Save(MDEstados oMDEstados);
        void Update(MDEstados oMDEstados);
        string Delete(int id_estad);
    }
}
