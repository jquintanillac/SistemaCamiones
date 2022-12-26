using Driver.web.Data.Entities;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDTipo_servicioServices
    {
        List<MDTipo_servicio> GetAll();
        MDTipo_servicio GetbyId(int id_tipserv);

        void Save(MDTipo_servicio oTiposerv);
        void Update(MDTipo_servicio oTiposerv);
        string Delete(int id_tipserv);
    }
}
