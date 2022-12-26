using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDTransportistaServices
    {
        List<MDTransportista> GetAll();
        MDTransportista GetbyId(int id_transp);
        void Save(MDTransportista oMDTransportista);
        void Update(MDTransportista oMDTransportista);
        string Delete(int id_transp);
    }
}
