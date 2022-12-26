using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDModeloServices
    {
        List<MDModelo> GetAll();
        MDModelo GetbyId(int id_modelo);

        void Save(MDModelo oDModelo);
        void Update(MDModelo oDModelo);
        string Delete(int id_modelo);
    }
}
