  
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crmUrbano.Models
{
    [Table("t_consulta")]
    public class Consulta
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id {get; set; }

        public string Nombre {get; set; }

        public string Email {get; set; }

        public string Consult {get; set; }
    }
}