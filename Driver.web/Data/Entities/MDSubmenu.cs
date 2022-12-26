using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Submenu")]
    public class MDSubmenu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_submenu { get; set; }
        public int id_menu { get; set; }
        public int submenu_iden { get; set; }
        public string submenu_desc { get; set; }
    }
}
