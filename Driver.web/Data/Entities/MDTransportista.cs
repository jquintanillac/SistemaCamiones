using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Transportista")]
    public class MDTransportista
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_transp { get; set; }
        public string transp_doc { get; set; }
        public string transp_desc { get; set; }
        public bool transp_act { get; set; }

    }
}
