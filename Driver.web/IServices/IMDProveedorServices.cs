using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDProveedorServices
    {
        List<MDProveedor> GetAll();
        MDProveedor GetbyId(int id_proveedor);

        void Save(MDProveedor oMDProveedor);
        void Update(MDProveedor oMDProveedor);
        string Delete(int id_proveedor);
    }
}
