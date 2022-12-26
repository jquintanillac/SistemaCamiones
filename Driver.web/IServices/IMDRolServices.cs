using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDRolServices
    {
        List<MDRol> GetAll();
        MDRol GetbyId(int Idrol);

        void Save(MDRol oMDRol);
        void Update(MDRol oMDRol);
        string Delete(int Idrol);
    }
}
