using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Driver.web.Data.Entities
{
    [Table("Terceros_camion")]
    public class MDRepuestos_Terceros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_repter { get; set; }
        public int id_vehi { get; set; }
        public int id_product { get; set; }
        public string repter_desc { get; set; }
        public int repter_cant { get; set; }
        public double repter_costo { get; set; }
        public DateTime repter_fecreg { get; set; }
        public DateTime repter_fecsal { get; set; }
    }
}
