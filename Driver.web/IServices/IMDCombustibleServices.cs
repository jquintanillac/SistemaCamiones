using Driver.web.Data.Entities;
using Driver.web.Models;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDCombustibleServices
    {
        List<VMDCombustible> GetAll();
        MDCombustible GetbyId(int id_combu);

        void Save(MDCombustible omDCombustible);
        void Update(MDCombustible omDCombustible);
        string Delete(int id_combu);
    }
}
