using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Viaticos_Cabecera")]
    public class MDViaticos_Cabecera
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_viatcab { get; set; }
        public int id_servcab { get; set; }
        public string viatcab_desc { get; set; }
        public double? viatcab_total { get; set; }
        public string viatcab_obs { get; set; }
        public DateTime viatcab_fecentre { get; set; }

    }
}
