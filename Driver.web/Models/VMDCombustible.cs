using System;

namespace Driver.web.Models
{
    public class VMDCombustible
    {
        public int id_combu { get; set; }
        public int id_vehi { get; set; }
        public int id_grifo { get; set; }
        public string vehi_placa { get; set; }        
        public string grifo_descr { get; set; }
        public string combu_obs { get; set; }
        public DateTime combu_fecreg { get; set; }
        public decimal combu_cant { get; set; }
        public decimal combu_prec { get; set; }
    }
}
