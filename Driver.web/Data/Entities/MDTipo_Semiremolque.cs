using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Tipo_Semiremolque")]
    public class MDTipo_Semiremolque
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_Tipsemi { get; set; }
        public string Tipsemi_desc { get; set; }
        public string Tipsemi_cod { get; set; }
        public bool Tipsemi_act { get; set; }

    }
}
