using Driver.web.Data.Entities;
using System.Collections.Generic;

namespace Driver.web.IServices
{
    public interface IMDFactura_cabeceraServices
    {
        List<MDFactura_Cabecera> GetAll();
        MDFactura_Cabecera GetbyId(int id_faccab);

        void Save(MDFactura_Cabecera omDFactura_Cabecera);
        void Update(MDFactura_Cabecera omDFactura_Cabecera);
        string Delete(int id_faccab);
    }
}
