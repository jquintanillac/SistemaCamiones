using System;

namespace Driver.web.Models
{
    public class VMDRepuestos_Terceros
    {
        public int id_repter { get; set; }
        public int id_vehi { get; set; }
        public int id_product { get; set; }
        public string product_descr { get; set; }
        public string vehi_placa { get; set; }
        public string repter_desc { get; set; }
        public int repter_cant { get; set; }
        public double repter_costo { get; set; }
        public DateTime repter_fecreg { get; set; }
        public DateTime repter_fecsal { get; set; }
    }
}
