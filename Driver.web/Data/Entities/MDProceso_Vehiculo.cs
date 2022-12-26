using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Driver.web.Data.Entities
{
    [Table("Proceso_vehiculo")]
    public class MDProceso_Vehiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_provehi { get; set; }
        public int id_vehi { get; set; }
        public int id_proces { get; set; }
        public double provehi_totalh { get; set; }
        public string provehi_obs { get; set; }

    }
}
