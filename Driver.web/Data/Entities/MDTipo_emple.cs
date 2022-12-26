using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Tipo_empleado")]
    public class MDTipo_emple
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_tipempl { get; set; }
        public string tipempl_desc { get; set; }
        public bool tipempl_act { get; set; }
    }
}
