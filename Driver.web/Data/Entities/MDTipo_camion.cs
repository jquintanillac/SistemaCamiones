using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Tipo_Camion")]
    public class MDTipo_camion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_Tipcam { get; set; }
        public string Tipcam_desc { get; set; }
        public string Tipcam_cod { get; set; }
        public bool Tipcam_act { get; set; }

    }
}
