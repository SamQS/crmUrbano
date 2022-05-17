using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace crmUrbano.Models
{
    [Table("t_carrito")]
    public class Carrito
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}

        public String Usuario {get; set;}        

        public double Price { get; set; }

        public Catalogo Catalogo {get; set; }

        public int CatalogoID { get; set; }

    }
}