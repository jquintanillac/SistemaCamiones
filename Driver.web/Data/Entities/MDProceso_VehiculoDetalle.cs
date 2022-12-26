using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Driver.web.Data.Entities
{
    [Table("Proceso_Vehiculo_Detalle")]
    public class MDProceso_VehiculoDetalle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_provehidet { get; set; }
        public int id_provehi { get; set; }
        public int id_estad { get; set; }
        public DateTime provehidet_fecini { get; set; }
        public DateTime provehidet_fecfin { get; set; }

    }
}
