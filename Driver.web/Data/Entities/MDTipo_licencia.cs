using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Tipo_Licencia")]
    public class MDTipo_licencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_tiplinc { get; set; }
        public string tiplinc_desc { get; set; }
        public string tiplinc_cod { get; set; }
    }
}
