using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Servicio_Detalle")]
    public class MDServicio_Detalle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_servdet { get; set; }
        public int id_servcab { get; set; }
        public int id_transp { get; set; }
        public int id_chofer { get; set; }
        public int id_vehi { get; set; }        
        public double servdet_cantdet { get; set; }
        public double servdet_preunit { get; set; }
        public DateTime servdet_Fecreg { get; set; }
    }
}
