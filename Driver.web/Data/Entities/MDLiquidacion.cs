using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Liquidacion")]
    public class MDLiquidacion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_liqui { get; set; }
        public int id_viatcab { get; set; }
        public string liqui_desc { get; set; }  
        public decimal liqui_monto { get; set; }     
        public DateTime liqui_fecreg { get; set; }
    }
}
