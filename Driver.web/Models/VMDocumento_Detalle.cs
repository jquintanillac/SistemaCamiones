using System;

namespace Driver.web.Models
{
    public class VMDocumento_Detalle
    {
        public int id_docdet { get; set; }
        public int id_doccab { get; set; }
        public int id_tipdoc { get; set; }
        public string tipdoc_desc { get; set; }
        public DateTime docdet_fecemi { get; set; }
        public DateTime docdet_venci { get; set; }     
        public string docdet_entemi { get; set; }
        public string docdet_alert { get; set; }
        public string docdet_obse { get; set; }
    }
}
