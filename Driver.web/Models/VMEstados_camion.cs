using System;

namespace Driver.web.Models
{
    public class VMEstados_camion
    {
        public int id_estcam { get; set; }
        public int id_estad { get; set; }
        public int id_vehi { get; set; }
        public string estad_desc { get; set; }
        public string vehi_placa { get; set; }
        public DateTime estcam_fecini { get; set; }
        public DateTime estcam_fecfin { get; set; }
        public string estcam_obs { get; set; }
    }
}
