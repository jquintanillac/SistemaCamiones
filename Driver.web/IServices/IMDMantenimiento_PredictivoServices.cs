using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDMantenimiento_PredictivoServices
    {
        List<MDMantenimiento_Predictivo> GetAll();
        MDMantenimiento_Predictivo GetbyId(int id_mantpred);

        void Save(MDMantenimiento_Predictivo oMDMantenimiento_Predictivo);
        void Update(MDMantenimiento_Predictivo oMDMantenimiento_Predictivo);
        string Delete(int id_mantpred);
    }
}
