using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class Cargo
    {
        [Key]
        public int Id_Cargo { get; set; }

       

        [Required]
        [StringLength(80)]
        public String Nombre_Cargo { get; set; }

        // public Empleado Empleado { get; set; }
       // public Empleado Empleado { get; set; }
    }
}