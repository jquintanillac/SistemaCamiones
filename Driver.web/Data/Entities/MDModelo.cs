using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Modelo")]
    public class MDModelo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_modelo { get; set; }
        public string modelo_desc { get; set; }
        public string modelo_cod { get; set; }
        public bool modelo_act { get; set; }
    }
}
