using Driver.web.Data.Entities;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDTipo_empleServices
    {
        List<MDTipo_emple> GetAll();
        MDTipo_emple GetbyId(int id_tipempl);
        void Save(MDTipo_emple oDTipo_Emple);
        void Update(MDTipo_emple oDTipo_Emple);
        string Delete(int id_tipempl);
    }
}
