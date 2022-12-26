using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Ubigeo")]
    public class MDUbigeo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_ubigeo { get; set; }
        public string ubig_depa { get; set; }
        public string ubig_prov { get; set; }
        public string ubig_dist { get; set; }
        public string ubig_cod { get; set; }
        public string ubig_desc { get; set; }
    }
}
