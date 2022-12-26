using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Mantenimiento_Predictivo")]
    public class MDMantenimiento_Predictivo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_mantpred { get; set; }
        public int id_plac { get; set; }
        public int id_repuesto { get; set; }
        public string mantpred_descr { get; set; }
        public string mantpred_cod { get; set; }
        public DateTime mantpred_fecha { get; set; }
        public string mantpred_obser { get; set; }

    }
}
