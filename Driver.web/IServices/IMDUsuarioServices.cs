using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDUsuarioServices
    {
        List<MDUsuario> GetAll();
        MDUsuario GetbyId(int IdUsuario);

        void Save(MDUsuario oMDUsuario);
        void Update(MDUsuario oMDUsuario);
        string Delete(int IdUsuario);
        
    }
}
