using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Proveedor")]
    public class MDProveedor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_proveedor { get; set; }
        public int id_tipdoc { get; set; }
        public string prover_razsocial { get; set; }
        public string prover_dociden { get; set; }
        public string prover_producto { get; set; }
        public string prover_direccion { get; set; }
        public string prover_condpago { get; set; }
        public bool prover_act { get; set; }
    }
}
