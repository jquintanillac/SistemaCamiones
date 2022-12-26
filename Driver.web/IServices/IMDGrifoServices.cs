using Driver.web.Data.Entities;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDGrifoServices
    {
        List<MDGrifo> GetAll();
        MDGrifo GetbyId(int id_grifo);
        void Save(MDGrifo oDGrifo);
        void Update(MDGrifo oDGrifo);
        string Delete(int id_grifo);
    }
}
