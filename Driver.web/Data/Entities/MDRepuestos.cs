using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Repuestos")]
    public class MDRepuestos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_repuesto { get; set; }
        public int id_product { get; set; }
        public string repus_iden { get; set; }        
        public int repus_cant { get; set; }
        public double repus_preuni { get; set; }
        public bool repus_act { get; set; }
        public DateTime repus_fecing { get; set; }
        
    }
}
