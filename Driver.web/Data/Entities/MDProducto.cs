using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Driver.web.Data.Entities
{
    [Table("Producto")]
    public class MDProducto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_product { get; set; }
        public string product_descr { get; set; }
        public bool   product_act { get; set; }

    }
}
