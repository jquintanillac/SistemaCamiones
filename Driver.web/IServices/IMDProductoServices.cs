using Driver.web.Data.Entities;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDProductoServices
    {
        List<MDProducto> GetAll();
        MDProducto GetbyId(int id_product);

        void Save(MDProducto oProdcut);
        void Update(MDProducto oProdcut);
        string Delete(int id_product);
    }
}
