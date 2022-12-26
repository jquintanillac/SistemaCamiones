using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDMarcaServices
    {
        List<MDMarca> GetAll();
        MDMarca GetbyId(int id_marca);

        void Save(MDMarca oDModelo);
        void Update(MDMarca oDModelo);
        string Delete(int id_marca);
    }
}
