using Driver.web.Data.Entities;
using Driver.web.Models;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDInventarioServices
    {
        List<VMDInventario> GetAll();
        MDInventario GetbyId(int id_invet);
        void Save(MDInventario oMDChofer);
        void Update(MDInventario oMDChofer);
        string Delete(int id_invet);
    }
}
