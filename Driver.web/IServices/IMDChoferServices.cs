using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDChoferServices
    {
        List<MDChofer> GetAll();
        MDChofer GetbyId(int id_chofer);

        void Save(MDChofer oMDChofer);
        void Update(MDChofer oMDChofer);
        string Delete(int id_chofer);
    }
}
