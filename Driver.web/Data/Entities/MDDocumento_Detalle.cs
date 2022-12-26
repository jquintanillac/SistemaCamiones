using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Documento_Detalle")]
    public class MDDocumento_Detalle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_docdet { get; set; }
        public int id_doccab { get; set; }
        public int id_tipdoc { get; set; }
        public DateTime docdet_fecemi { get; set; }
        public DateTime docdet_venci { get; set; }
        public DateTime docdet_regis { get; set; }
        public string docdet_entemi { get; set; }
        public string? docdet_obse { get; set; }
    }
}
