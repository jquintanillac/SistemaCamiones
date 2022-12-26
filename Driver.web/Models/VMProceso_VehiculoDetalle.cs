using System;

namespace Driver.web.Models
{
    public class VMProceso_VehiculoDetalle
    {
        public int id_provehidet { get; set; }
        public int id_provehi { get; set; }
        public int id_estad { get; set; }
        public string proces_desc { get; set; }
        public string estad_desc { get; set; }
        public DateTime? provehidet_fecini { get; set; }
        public DateTime? provehidet_fecfin { get; set; }
    }
}
