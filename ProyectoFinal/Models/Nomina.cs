using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ProyectoFinal.Models
{
    public class Nomina
    {
        [Key]
        public int Id_Nomina { get; set; }
        public int Año { get; set; }
        public int Mes { get; set; }
        public decimal Monto_Total { get; set; }

        //public Empleado Empleado { get; set; }
        // public List<Empleado> Empleados { get; set; }
    }
}