using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Driver.web.Data.Entities
{
    [Table("Cliente")]
    public class MDCliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_cliente { get; set; }
        public int id_tipdoc { get; set; }
        public string clie_dociden { get; set; }
        public string clie_razsocial { get; set; }
        public string clie_condpag { get; set; }
        public string clie_reqpart { get; set; }   
        public bool clie_act  { get; set; }

    }
}
