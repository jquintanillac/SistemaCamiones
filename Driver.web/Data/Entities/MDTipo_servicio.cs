using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Driver.web.Data.Entities
{
    [Table("Tipo_Servicio")]
    public class MDTipo_servicio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_tipserv { get; set; }
        public string tipserv_descr { get; set; }
        public bool tipserv_act { get; set; }
    }
}
