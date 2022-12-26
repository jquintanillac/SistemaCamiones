using System;

namespace Driver.web.Models
{
    public class VMViatico_Detalle
    {
        public int id_viatdet { get; set; }
        public int id_viatcab { get; set; }
        public int id_chofer { get; set; }
        public string chof_nomcomp { get; set; }
        public string viatdet_concep { get; set; }
        public string viatdet_monuni { get; set; }
        public DateTime viatdet_fecini { get; set; }
        public DateTime viajdet_fecfin { get; set; }
    }
}
