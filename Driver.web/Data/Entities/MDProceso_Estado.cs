using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Driver.web.Data.Entities
{
    [Table("Proceso_Estado")]
    public class MDProceso_Estado
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_proest { get; set; }
        public int id_proces { get; set; }
        public int id_estad { get; set; }
        public string proest_obs { get; set; }

    }
}
