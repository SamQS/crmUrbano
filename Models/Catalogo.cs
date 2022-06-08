  
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace crmUrbano.Models
{
    [Table("t_catalogo")]
    public class Catalogo
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int ID{get;set;}

        public String Name {get; set;}

        public String Direccion {get; set;}

        [DisplayFormat(DataFormatString = "{0:N0}")]
        public double Price {get; set;}

        public String ImagenName { get; set;}

        public String Status {get; set;}

        
        public virtual ICollection<Carrito> Carrito { get; set; }

  


        


        
    }
}