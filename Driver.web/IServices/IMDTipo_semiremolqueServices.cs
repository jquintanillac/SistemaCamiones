using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDTipo_semiremolqueServices
    {
        List<MDTipo_Semiremolque> GetAll();
        MDTipo_Semiremolque GetbyId(int id_Tipsemi);
        void Save(MDTipo_Semiremolque oDTipo_Semiremolque);
        void Update(MDTipo_Semiremolque oDTipo_Semiremolque);
        string Delete(int id_Tipsemi);
    }
}
