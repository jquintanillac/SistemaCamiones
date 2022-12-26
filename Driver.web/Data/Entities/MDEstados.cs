using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Estados")]
    public class MDEstados
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_estad { get; set; }
        public string estad_iden { get; set; }
        public string estad_desc { get; set; }
        public bool estad_act { get; set; }
    }
}
