using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Generales")]
    public class MDGenerales
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_gene { get; set; }
        public string gene_emp { get; set; }
        public string gene_ruc { get; set; }
        public string gene_direc  { get; set; }
        public string gene_telef { get; set; }

    }
}
