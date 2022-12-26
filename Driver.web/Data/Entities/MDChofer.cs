using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Chofer")]
    public class MDChofer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_chofer { get; set; }       
        public int id_tipempl { get; set; }
        public int id_cliente { get; set; }
        public int id_espec { get; set; }
        public int id_concontrac { get; set; }
        public string chofer_nombre { get; set; }
        public string chofer_apellido { get; set; }
        public DateTime chofer_fecnac { get; set; }
        public double chofer_score { get; set; }
        public double chofer_incid { get; set; }
        public bool chofer_act { get; set; }
        public DateTime chofer_fecingr { get; set; }
        public DateTime? chofer_feccese { get; set; }
    }
}
