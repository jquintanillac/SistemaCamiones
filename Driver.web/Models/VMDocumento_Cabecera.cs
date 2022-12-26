using System;

namespace Driver.web.Models
{
    public class VMDocumento_Cabecera
    {
        public int id_doccab { get; set; }
        public int id_chofer { get; set; }
        public string chof_nomcomp { get; set; }
        public int id_vehi { get; set; }
        public string vehi_placa { get; set; }
        public string doccab_tipo { get; set; }
        public string doccab_cod { get; set; }
        public string doccab_desc { get; set; }
        public string doccab_est { get; set; }

    }
}
