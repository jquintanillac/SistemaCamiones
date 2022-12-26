using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Carga")]
    public class MDCarga
    {
        [Key]       
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_carga { get; set; }
        [Required(ErrorMessage = "El campo es requerido.")]
        [Display(Name = "Descripcion")]
        public string carg_desc { get; set; }
        [Required]
        [Display(Name = "Codigo")]
        public string carg_cod { get; set; }
        [Display(Name = "Activo?")]
        public bool carg_act { get; set; }        
    }
}
