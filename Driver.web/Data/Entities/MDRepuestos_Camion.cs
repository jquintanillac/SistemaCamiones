using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Repuestos_Camion")]
    public class MDRepuestos_Camion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_repcam { get; set; }
        public int id_product { get; set; }
        public int id_vehi { get; set; }        
        public string repcam_desc { get; set; }
        public int repcam_cant { get; set; }
        public DateTime repcam_fecreg { get; set; }
        public DateTime repcam_fecsal { get; set; }
    }
}
