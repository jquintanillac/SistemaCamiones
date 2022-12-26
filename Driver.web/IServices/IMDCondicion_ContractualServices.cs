using Driver.web.Data.Entities;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDCondicion_ContractualServices
    {
        List<MDCondicion_Contractual> GetAll();
        MDCondicion_Contractual GetbyId(int id_concontrac);

        void Save(MDCondicion_Contractual oContrac);
        void Update(MDCondicion_Contractual oContrac);
        string Delete(int id_concontrac);
    }
}
