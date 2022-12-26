using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Driver.web.Data.Entities
{
    [Table("Factura_Cabecera")]
    public class MDFactura_Cabecera
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_faccab { get; set; }
        public int id_cliente { get; set; }
        public int id_servcab { get; set; }
        public int id_tipdoc { get; set; }
        public string faccab_serie { get; set; }
        public string faccab_nro { get; set; }   
        public DateTime faccab_fecreg { get; set; }
        public DateTime faccab_fecvenc { get; set; }
        public decimal faccab_monto { get; set; }
        public decimal faccab_igv { get; set; }
        public decimal faccab_total { get; set; }


    }
}
