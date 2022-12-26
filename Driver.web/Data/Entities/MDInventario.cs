using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Driver.web.Data.Entities
{
    [Table("Inventario")]
    public class MDInventario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_invet { get; set; }
        public int id_product { get; set; }
        public int invet_cant { get; set; }
        public double invet_prepro { get; set; }
        public double invet_pretotal { get; set; }
        public bool invet_act { get; set; }        
    }
}
