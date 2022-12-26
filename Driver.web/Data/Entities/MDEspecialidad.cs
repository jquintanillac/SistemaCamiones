using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Driver.web.Data.Entities
{
    [Table("Tipo_especialidad")]
    public class MDEspecialidad
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_espec { get; set; }
        public string espec_desc { get; set; }
        public string espec_cod { get; set; }

    }
}
