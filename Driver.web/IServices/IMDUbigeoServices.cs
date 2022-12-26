using System.Collections.Generic;
using Driver.web.Data.Entities;


namespace Driver.web.IServices
{
    public interface IMDUbigeoServices
    {
        List<MDUbigeo> GetAll();
        MDUbigeo GetbyId(int id_ubigeo);
        void Save(MDUbigeo oMDUbigeo);
        void Update(MDUbigeo oMDUbigeo);
        string Delete(int id_ubigeo);
    }
}
