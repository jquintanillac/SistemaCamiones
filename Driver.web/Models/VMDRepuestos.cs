using System;

namespace Driver.web.Models
{
    public class VMDRepuestos
    {
        public int id_repuesto { get; set; }
        public int id_product { get; set; }
        public string repus_iden { get; set; }
        public string product_descr { get; set; }
        public int repus_cant { get; set; }
        public double repus_preuni { get; set; }
        public bool repus_act { get; set; }
        public DateTime repus_fecing { get; set; }
    }
}
