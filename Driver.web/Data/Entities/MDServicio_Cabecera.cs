using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Servicio_Cabecera")]
    public class MDServicio_Cabecera
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_servcab { get; set; }
        public int? id_cliente { get; set; }
        public int? id_carga { get; set; }
        public int? id_ubigeo_partida { get; set; }
        public int? id_ubigeo_llegada { get; set; }
        public int id_tipserv { get; set; }
        public string servcab_nro { get; set; }
        public double servcab_canttotal { get; set; }
        public string servcab_desc { get; set; }
        public string servcab_guia { get; set; }
        public DateTime servcab_fec { get; set; }
        public double servcab_montotal { get; set; }
        public double servcab_km { get; set; }
        public string servcab_obs { get; set; }
        public DateTime servcab_fecreg { get; set; }
        
    }
}
