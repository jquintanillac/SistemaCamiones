using Driver.web.Data.Entities;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDcargaServices
    {
        List<MDCarga> GetMDCargas();
        MDCarga GetbyId(int id_carga);

        void Save(MDCarga oMDcarga);
        void Update(MDCarga oMDcarga);
        string Delete(int id_carga);
    }
}
