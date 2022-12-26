using Driver.web.Data.Entities;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDProcesoServices
    {
        List<MDProceso> GetAll();
        MDProceso GetbyId(int id_proces);
        void Save(MDProceso oProceso);
        void Update(MDProceso oProceso);
        string Delete(int id_proces);
    }
}
