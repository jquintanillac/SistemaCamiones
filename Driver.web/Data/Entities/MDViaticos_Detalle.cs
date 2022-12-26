using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Viaticos_Detalle")]
    public class MDViaticos_Detalle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_viatdet { get; set; }
        public int id_viatcab { get; set; }
        public int id_chofer { get; set; }
        public string viatdet_concep { get; set; }
        public string viatdet_monuni { get; set; }
        public DateTime viatdet_fecini { get; set; }
        public DateTime viajdet_fecfin { get; set; }
    }
}
