using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Tipo_Documento")]
    public class MDTipo_documento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_tipdoc { get; set; }
        public string tipdoc_desc { get; set; }
        public string tipdoc_tipo { get; set; }      
        public bool tipdoc_act { get; set;}
    }
}
