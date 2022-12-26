using System.Collections.Generic;
using Driver.web.Data.Entities;
using Driver.web.Models;

namespace Driver.web.IServices
{
    public interface IMDRepuestosServices
    {
        List<VMDRepuestos> GetAll();
        MDRepuestos GetbyId(int id_repuesto);

        void Save(MDRepuestos oMDRepuestos);
        void Update(MDRepuestos oMDRepuestos);
        string Delete(int id_repuesto);
    }
}
