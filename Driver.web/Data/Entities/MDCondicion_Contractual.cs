using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Condicion_Contractual")]
    public class MDCondicion_Contractual
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_concontrac { get; set; }
        public string concontrac_desc { get; set; }
        public string concontrac_cod { get; set; }
    }
}
