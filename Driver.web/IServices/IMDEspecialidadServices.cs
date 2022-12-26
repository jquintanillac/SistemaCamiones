using Driver.web.Data.Entities;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDEspecialidadServices
    {
        List<MDEspecialidad> GetAll();
        MDEspecialidad GetbyId(int id_espec);
        void Save(MDEspecialidad oDEspecialidad);
        void Update(MDEspecialidad oDEspecialidad);
        string Delete(int id_espec);
    }
}
