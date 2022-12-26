using Driver.web.Data.Entities;
using Driver.web.Models;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDRepuestos_TercerosServices
    {
        List<VMDRepuestos_Terceros> GetAll();
        MDRepuestos_Terceros GetbyId(int id_repter);

        void Save(MDRepuestos_Terceros oReputer);
        void Update(MDRepuestos_Terceros oReputer);
        string Delete(int id_repter);
    }
}
