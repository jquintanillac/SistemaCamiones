using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Rol_Permisos")]
    public class MDRol_Permisos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_rolperm { get; set; }
        public int Idrol { get; set; }
        public int id_menu { get; set; }
        public int id_submenu { get; set; }
        public bool rolperm_act { get; set; }
    }
}
