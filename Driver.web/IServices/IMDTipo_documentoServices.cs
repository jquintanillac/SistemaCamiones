using System.Collections.Generic;
using Driver.web.Data.Entities;


namespace Driver.web.IServices
{
    public interface IMDTipo_documentoServices
    {
        List<MDTipo_documento> GetAll();
        MDTipo_documento GetbyId(int id_tipdoc);
        void Save(MDTipo_documento oMDTipo_documento);
        void Update(MDTipo_documento oMDTipo_documento);
        string Delete(int id_tipdoc);
    }
}
