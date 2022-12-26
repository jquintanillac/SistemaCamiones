using System;

namespace Driver.web.Models
{
    public class VMDRepuestos_Camion
    {
        public int id_repcam { get; set; }
        public int id_product { get; set; }
        public int id_vehi { get; set; }
        public string vehi_placa { get; set; }
        public string product_descr { get; set; }
        public string repcam_desc { get; set; }
        public int repcam_cant { get; set; }
        public DateTime repcam_fecreg { get; set; }
        public DateTime repcam_fecsal { get; set; }
    }
}
