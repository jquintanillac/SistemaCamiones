using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;



namespace Driver.web.Data.Entities
{
    [Table("Combustible")]
    public class MDCombustible
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_combu { get; set; }
        public int id_vehi { get; set; }
        public int id_grifo { get; set; }
        public string? combu_obs { get; set; }
        public DateTime combu_fecreg { get; set; }
        public decimal combu_cant  { get; set; }
        public decimal combu_prec { get; set; }


    }
}
