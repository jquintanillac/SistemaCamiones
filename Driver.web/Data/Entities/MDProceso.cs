using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Driver.web.Data.Entities
{
    [Table("Proceso")]
    public class MDProceso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_proces { get; set; }
        public string proces_desc { get; set; }
        public string proces_cod  { get; set; }
        public bool proces_act { get; set; }       

    }
}
