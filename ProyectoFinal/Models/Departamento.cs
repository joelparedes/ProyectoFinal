using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Departamento
    {
        [Key]
        public int Id_Depto { get; set; }

        [Required]
        [StringLength(4)]
        public String Codigo_Depto { get; set; }

        [StringLength(50)]
        public String Nombre_Depto { get; set; }

        //public Empleado Empleado { get; set; }
        public List<Empleado> Empleados { get; set; }
    }
}