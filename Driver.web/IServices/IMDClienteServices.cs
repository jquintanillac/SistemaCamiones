using System.Collections.Generic;
using Driver.web.Data.Entities;

namespace Driver.web.IServices
{
    public interface IMDClienteServices
    {
        List<MDCliente> GetAll();
        MDCliente GetbyId(int id_cliente);
        void Save(MDCliente oMDCliente);
        void Update(MDCliente oMDCliente);
        string Delete(int id_cliente);
    }
}
