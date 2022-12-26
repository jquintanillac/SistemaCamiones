using Driver.web.Data.Entities;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDTipo_licenciaServices
    {
        List<MDTipo_licencia> GetAll();
        MDTipo_licencia GetbyId(int id_tiplinc);
        void Save(MDTipo_licencia oDTipo_Licencia);
        void Update(MDTipo_licencia oDTipo_Licencia);
        string Delete(int id_tiplinc);
    }
}
