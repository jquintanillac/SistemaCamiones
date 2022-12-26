using Driver.web.Data.Entities;
using System.Collections.Generic;


namespace Driver.web.IServices
{
    public interface IMDLiquidacionServices
    {
        List<MDLiquidacion> GetAll();
        MDLiquidacion GetbyId(int id_liqui);

        void Save(MDLiquidacion oMDLiquidacion);
        void Update(MDLiquidacion oMDLiquidacion);
        string Delete(int id_liqui);
    }
}
