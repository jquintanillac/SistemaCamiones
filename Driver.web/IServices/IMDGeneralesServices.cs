using Driver.web.Data.Entities;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDGeneralesServices
    {
        List<MDGenerales> GetAll();
        MDGenerales GetbyId(int id_gene);

        void Save(MDGenerales oDGenerales);
        void Update(MDGenerales oDGenerales);
        string Delete(int id_gene);

    }
}
