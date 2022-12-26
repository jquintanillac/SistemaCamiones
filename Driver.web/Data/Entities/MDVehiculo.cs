using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Driver.web.Data.Entities
{
    [Table("Vehiculo")]
    public class MDVehiculo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_vehi { get; set; }
        public int id_Tipcam { get; set; }
        public int id_Tipsemi { get; set; }
        public int id_cliente { get; set; }
        public int id_modelo { get; set; }
        public int id_marca { get; set; }
        public string vehi_placa { get; set; }       
        public string vehi_km { get; set; }
        public string vehi_año { get; set; }
        public bool vehi_act { get; set; }
    }
}
