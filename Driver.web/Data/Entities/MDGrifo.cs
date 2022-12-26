using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Grifo")]
    public class MDGrifo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_grifo { get; set; }      
        public string grifo_descr { get; set; }
        public string grifo_direc { get; set; }
        public bool grifo_act { get; set; }

    }
}
