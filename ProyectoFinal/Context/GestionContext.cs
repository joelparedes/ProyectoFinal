using ProyectoFinal.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Context
{
    public class GestionContext: DbContext
    {
        public GestionContext()
            : base("DbConnection")
        {

        }

        public DbSet<Empleado> Empleados { get; set; }  // Listado empleados
        public DbSet<Departamento> Departamentos { get; set; } // listado departamentos
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Licencia> Licencias { get; set; }
        public DbSet<Permiso> Permisos { get; set; }
        public DbSet<Salida_Empleado> Salidas_Empleados { get; set; }
        public DbSet<Vacacion> Vacacions { get; set; }


        public DbSet<Nomina> GetNominas { get; set; }
    }
}