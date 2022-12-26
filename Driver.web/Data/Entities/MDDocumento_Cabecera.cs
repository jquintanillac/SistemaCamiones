using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Documento_Cabecera")]
    public class MDDocumento_Cabecera
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_doccab { get; set; }
        public int id_chofer { get; set; }
        public int id_vehi { get; set; }
        public string doccab_tipo { get; set; }
        public string? doccab_cod { get; set; }
        public string? doccab_desc { get; set; }
        public DateTime? doccab_fecreg { get; set; }
    }
}
