using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sistema_De_Prestamos.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El Campo {0} Es Obligatorio")]
        [StringLength(60)]
        
        public string Name
        {
            get; set;
        }
        [Required(ErrorMessage ="El Campo {0} Es Oblicatorio")]
        [StringLength(100)]

       
       public string Apellidos { get; set; }
       [Required(ErrorMessage = "El Campo {0} Es Obligatorio")]
       [StringLength(200)]
    
        public string Direccion { get; set; }
        public virtual ICollection<Prestamos> Prestamos { get; set; }

    }
}