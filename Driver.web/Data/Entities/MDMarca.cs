using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Marca")]
    public class MDMarca
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_marca { get; set; }
        public string marca_desc { get; set; }
        public string marca_cod { get; set; }
        public bool marca_act { get; set; }
    }
}
