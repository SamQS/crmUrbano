using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace crmUrbano.Models
{
    [Table("t_carrit")]
    public class Carrito
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID {get; set;}

        public String Usuario {get; set;} 


        [DisplayFormat(DataFormatString = "{0:N0}")]
        public double Price { get; set; }

        public String Direccion {get; set;}
        
        public String Name {get; set;}

        public String ImagenName { get; set;}

        public Catalogo Catalogo {get; set; }

        public int CatalogoID { get; set; }

    }
}